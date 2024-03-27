using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVIstas;
using SistemasVentas.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaEditarVista : Form
    {
        int idx = 0;
        DetalleVenta p = new DetalleVenta();
        DetalleVentaBSS bss = new DetalleVentaBSS();
        public static int IdVentaSeleccionada = 0;
        VentaBSS bssven = new VentaBSS();
        public static int IdProductoSeleccionada = 0;
        ProductoBSS bsspro = new ProductoBSS();
        public DetalleVentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void DetalleVentaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerDetalleVentaIdBss(idx);
            textBox1.Text = p.IdVenta.ToString();
            textBox2.Text = p.IdProducto.ToString();
            textBox3.Text = p.Cantidad.ToString();
            textBox4.Text = p.PrecioVenta.ToString();
            textBox5.Text = p.SubTotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdVenta = IdVentaSeleccionada;
            p.IdProducto = IdProductoSeleccionada;
            p.Cantidad = Convert.ToInt32(textBox3.Text);
            p.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            p.SubTotal = Convert.ToDecimal(textBox5.Text);

            bss.EditarDetalleVentaBss(p);
            MessageBox.Show("Datos Actualizados");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentaListarVistas fr = new VentaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bssven.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox1.Text = venta.IdVenta.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspro.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox2.Text = producto.Nombre;
            }
        }
    }
}
