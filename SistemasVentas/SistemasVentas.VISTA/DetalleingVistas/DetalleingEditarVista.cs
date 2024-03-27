using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.ProductoVIstas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.DetalleingVistas
{
    public partial class DetalleingEditarVista : Form
    {
        int idx = 0;
        Detalleing p = new Detalleing();
        DetalleingBSS bss = new DetalleingBSS();
        public static int IdProductoSeleccionada = 0;
        ProductoBSS bsspro = new ProductoBSS();
        public static int IdIngresoSeleccionada = 0;
        IngresoBSS bssing = new IngresoBSS();
        public DetalleingEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void DetalleingEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerDetalleIngIdBss(idx);
            textBox1.Text = p.IdIngreso.ToString();
            textBox2.Text = p.IdProducto.ToString();
            dateTimePicker1.Value = p.FechaVenc;
            textBox3.Text = p.Cantidad.ToString();
            textBox4.Text = p.PrecioCosto.ToString();
            textBox5.Text = p.PrecioVenta.ToString();
            textBox6.Text = p.SubTotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdIngreso = IdIngresoSeleccionada;
            p.IdProducto = IdProductoSeleccionada;
            p.FechaVenc = dateTimePicker1.Value;
            p.Cantidad = Convert.ToInt32(textBox3.Text);
            p.PrecioCosto = Convert.ToDecimal(textBox4.Text);
            p.PrecioVenta = Convert.ToDecimal(textBox5.Text);
            p.SubTotal = Convert.ToDecimal(textBox6.Text);

            bss.EditarDetalleIngBss(p);
            MessageBox.Show("Datos Actualizados");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspro.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox1.Text = producto.Nombre;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IngresoListarVistas fr = new IngresoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bssing.ObtenerIngresoIdBss(IdIngresoSeleccionada);
                textBox2.Text = ingreso.IdIngreso.ToString();
            }
        }
    }
}
