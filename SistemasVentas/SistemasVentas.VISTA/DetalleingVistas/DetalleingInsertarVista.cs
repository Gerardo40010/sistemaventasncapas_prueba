using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.PersonaVistas;
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

namespace SistemasVentas.VISTA.DetalleingVistas
{
    public partial class DetalleingInsertarVista : Form
    {
        public DetalleingInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdIngresoSeleccionado = 0;

        public static int IdProductoSeleccionado = 0;

        DetalleingBSS bss = new DetalleingBSS();
        IngresoBSS bssuser = new IngresoBSS();
        ProductoBSS bssuser2 = new ProductoBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            Detalleing d = new Detalleing();
            d.IdIngreso = IdIngresoSeleccionado;
            d.IdProducto = IdProductoSeleccionado;
            d.FechaVenc = dateTimePicker1.Value;
            d.Cantidad = Convert.ToInt32(textBox3.Text);
            d.PrecioCosto = Convert.ToDecimal(textBox4.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox5.Text);
            d.SubTotal = Convert.ToDecimal(textBox6.Text);

            bss.InsertarDetalleingBss(d);
            MessageBox.Show("Se guardo correctamente Detalleing");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IngresoListarVistas fr = new IngresoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso i = bssuser.ObtenerIngresoIdBss(IdIngresoSeleccionado);
                textBox1.Text = i.Estado;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto p = bssuser2.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox2.Text = p.Descripcion;
            }
        }
    }
}
