using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVistas;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.ProveeVistas
{
    public partial class ProveeInsertarVista : Form
    {
        public ProveeInsertarVista()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Provee provee = new Provee();
            provee.IdProducto = IdProductoSeleccionado;
            provee.IdProveedor = IdProveedorSeleccionado;
            provee.Fecha = dateTimePicker1.Value;
            provee.Precio = Convert.ToDecimal(textBox3.Text);

            bss.InsertarProveeBss(provee);
            MessageBox.Show("Se guardo correctamente el Provee");
        }

        public static int IdProductoSeleccionado = 0;
        ProductoBss bssproducto = new ProductoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bssproducto.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox1.Text = producto.Nombre;
            }
        }

        public static int IdProveedorSeleccionado = 0;
        ProveedorBss bssproveedor = new ProveedorBss();
        private void button4_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bssproveedor.ObtenerProveedorIdBss(IdProveedorSeleccionado);
                textBox2.Text = proveedor.Nombre;
            }
        }
    }
}
