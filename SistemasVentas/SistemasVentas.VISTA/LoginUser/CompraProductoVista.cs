using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.ProductoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.LoginUser
{
    public partial class CompraProductoVista : Form
    {
        public CompraProductoVista()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("IdCliente", "ID Cliente");
            dataGridView1.Columns.Add("IdProducto", "ID Producto");
            dataGridView1.Columns.Add("NombreProducto", "Nombre Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
        }
        public static int IdProductoSeleccionado = 0;
        ProductoBss bssproducto = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            VendeProductoListarVista fr = new VendeProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bssproducto.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.Nombre;
            }
        }
        public static int IdClienteSeleccionado = 0;
        ClienteBss bsscliente = new ClienteBss();
        private void button2_Click(object sender, EventArgs e)
        {
            VendeClienteListarVista fr = new VendeClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bsscliente.ObtenerClienteIdBss(IdClienteSeleccionado);
                textBox1.Text = Convert.ToString(cliente.IdCliente);
            }
        }
        public void AgregarProductoSeleccionadoAlDataGridView(Producto producto, Cliente cliente, int cantidad)
        {
            if (dataGridView1 != null)
            {
                dataGridView1.Rows.Add(cliente.IdCliente, producto.IdProducto, producto.Nombre, cantidad);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = bsscliente.ObtenerClienteIdBss(IdClienteSeleccionado);
            Producto producto = bssproducto.ObtenerProductoIdBss(IdProductoSeleccionado);

            int cantidad;
            if (!int.TryParse(textBox3.Text, out cantidad))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AgregarProductoSeleccionadoAlDataGridView(producto, cliente, cantidad);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                saveDialog.FileName = "ReporteVentas.txt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        foreach (DataGridViewColumn columna in dataGridView1.Columns)
                        {
                            writer.Write(columna.HeaderText + "\t");
                        }
                        writer.WriteLine();

                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell celda in fila.Cells)
                            {
                                writer.Write(celda.Value.ToString() + "\t");
                            }
                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show("El archivo TXT ha sido creado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
