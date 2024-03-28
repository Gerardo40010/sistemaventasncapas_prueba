using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.IngresoVista;
using SistemasVentas.VISTA.ProductoVista;
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

namespace SistemasVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngInsertarVistas : Form
    {
        public DetalleIngInsertarVistas()
        {
            InitializeComponent();
        }
        public static int IdIngresoSeleccionado = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            IngresoBss bss = new IngresoBss();
            IngresoListarVista fr = new IngresoListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bss.ObtenerIdBss(IdIngresoSeleccionado);
                textBox1.Text = ingreso.FechaIngreso.ToString();
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
