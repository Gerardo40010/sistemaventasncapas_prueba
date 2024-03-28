using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVista;
using SistemasVentas.VISTA.TipoProdVista;
using SistemasVentas.VISTA.VentaVista;
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
    public partial class DetalleVentaInsertarVistas : Form
    {
        public DetalleVentaInsertarVistas()
        {
            InitializeComponent();
        }
        public static int IdVentaSeleccionado = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            VentaBss bss = new VentaBss();
            VentaListarVista fr = new VentaListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bss.ObtenerIdBss(IdVentaSeleccionado);
                textBox1.Text = venta.IdVendedor.ToString();
            }
        }

        public static int IdProductoSeleccionado = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            ProductoListarVista fr = new ProductoListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bss.ObtenerIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.Nombre;
            }
        }
    }
}
