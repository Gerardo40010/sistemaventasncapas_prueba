using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
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
    public partial class DetalleVentaIngresarVista : Form
    {
        public DetalleVentaIngresarVista()
        {
            InitializeComponent();
        }
        public static int IdVentaSeleccionada = 0;
        public static int IdProductoSeleccionada = 0;
        DetalleVentaBSS bss = new DetalleVentaBSS();
        VentaBSS bssuser = new VentaBSS();
        ProductoBSS bssuser2 = new ProductoBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta d = new DetalleVenta();
            d.IdVenta = IdVentaSeleccionada;
            d.IdProducto = IdProductoSeleccionada;
            d.Cantidad = Convert.ToInt32(textBox3.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            d.SubTotal = Convert.ToDecimal(textBox5.Text);

            bss.InsertarDetalleVentaBss(d);
            MessageBox.Show("Se guardo correctamente El detalle de la venta");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentaListarVistas fr = new VentaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta v = bssuser.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox1.Text = v.Estado;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto p = bssuser2.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox2.Text = p.Nombre;
            }
        }
    }
}
