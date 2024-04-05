using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.ProductoVistas;
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
        DetalleVenta detalleVenta = new DetalleVenta();
        DetalleVentaBss bss = new DetalleVentaBss();
        public DetalleVentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void DetalleVentaEditarVista_Load(object sender, EventArgs e)
        {
            detalleVenta = bss.ObtenerDetalleVentaIdBss(idx);
            textBox1.Text = Convert.ToString(detalleVenta.IdVenta);
            textBox2.Text = Convert.ToString(detalleVenta.IdProducto);
            textBox3.Text = Convert.ToString(detalleVenta.Cantidad);
            textBox4.Text = Convert.ToString(detalleVenta.PrecioVenta);
            textBox5.Text = Convert.ToString(detalleVenta.SubTotal);
            textBox6.Text = detalleVenta.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detalleVenta.IdVenta = IdVentaSeleccionada;
            detalleVenta.IdProducto = IdProductoSeleccionado;
            detalleVenta.Cantidad = Convert.ToInt32(textBox3.Text);
            detalleVenta.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            detalleVenta.SubTotal = Convert.ToDecimal(textBox5.Text);
            detalleVenta.Estado = textBox6.Text;

            bss.EditarDetalleVentaBss(detalleVenta);
            MessageBox.Show("Datos Actualizados");
        }

        public static int IdVentaSeleccionada = 0;
        VentaBss bssventa = new VentaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            VentaListarVista fr = new VentaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bssventa.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox1.Text = Convert.ToString(venta.IdVenta);
            }
        }

        public static int IdProductoSeleccionado = 0;
        ProductoBss bssproducto = new ProductoBss();
        private void button4_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bssproducto.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.Nombre;
            }
        }
    }
}
