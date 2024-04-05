using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.IngresoVistas;
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
    public partial class DetalleIngInsertarVista : Form
    {
        public DetalleIngInsertarVista()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIng detalleIng = new DetalleIng();
            detalleIng.IdIngreso = IdIngresoSeleccionado;
            detalleIng.IdProducto = IdProductoSeleccionado;
            detalleIng.FechaVenc = dateTimePicker1.Value;
            detalleIng.Cantidad = Convert.ToInt32(textBox3.Text);
            detalleIng.PrecioCosto = Convert.ToDecimal(textBox4.Text);
            detalleIng.PrecioVenta = Convert.ToDecimal(textBox5.Text);
            detalleIng.SubTotal = Convert.ToDecimal(textBox6.Text);
            detalleIng.Estado = textBox7.Text;

            bss.InsertarDetalleIngBss(detalleIng);
            MessageBox.Show("Se guardo correctamente el Detalle Ingreso");
        }
        public static int IdIngresoSeleccionado = 0;
        IngresoBss bssingreso = new IngresoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            IngresoListarVista fr = new IngresoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bssingreso.ObtenerIngresoIdBss(IdIngresoSeleccionado);
                textBox1.Text = Convert.ToString(ingreso.IdIngreso);
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
