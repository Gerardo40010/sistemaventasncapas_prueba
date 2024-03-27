using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVIstas;
using SistemasVentas.VISTA.ProveedorVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveeVistas
{
    public partial class ProveeEditarVista : Form
    {
        int idx = 0;
        Provee p = new Provee();
        ProveeBSS bss = new ProveeBSS();
        public static int IdProductoSeleccionada = 0;
        ProductoBSS bsspro = new ProductoBSS();
        public static int IdProveedorSeleccionada = 0;
        ProveedorBSS bssprov = new ProveedorBSS();
        public ProveeEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProveeEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerProveeIdBss(idx);
            textBox1.Text = p.IdProducto.ToString();
            textBox2.Text = p.IdProveedor.ToString();
            dateTimePicker1.Value = p.Fecha;
            textBox3.Text = p.Precio.ToString();
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
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bssprov.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox2.Text = proveedor.Nombre;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            p.IdProducto = IdProductoSeleccionada;
            p.IdProveedor = IdProveedorSeleccionada;
            p.Fecha = dateTimePicker1.Value;
            p.Precio = Convert.ToDecimal(textBox3.Text);

            bss.EditarProveeBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
