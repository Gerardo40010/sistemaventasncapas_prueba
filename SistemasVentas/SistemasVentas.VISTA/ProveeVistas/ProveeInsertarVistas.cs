using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVista;
using SistemasVentas.VISTA.ProveedorVista;
using SistemasVentas.VISTA.ProveeVista;
using SistemasVentas.VISTA.UsuarioVista;
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
    public partial class ProveeInsertarVistas : Form
    {
        public ProveeInsertarVistas()
        {
            InitializeComponent();
        }
        public static int IdProductoSeleccionado = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bss.ObtenerIdBss(IdProductoSeleccionado);
                textBox1.Text = producto.IdProducto.ToString();
            }
        }

        public static int IdProveedorSeleccionado = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            ProveedorBss bss = new ProveedorBss();
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bss.ObtenerIdBss(IdProveedorSeleccionado);
                textBox2.Text = proveedor.IdProveedor.ToString();
            }
        }
        ProveeBss bssuser = new ProveeBss();
        private void button3_Click(object sender, EventArgs e)
        {
            Provee provee = new Provee();
            provee.IdProducto = IdProductoSeleccionado;
            provee.IdProveedor = IdProveedorSeleccionado;     
            provee.Fecha = dateTimePicker1.Value;
            provee.Precio = Convert.ToInt32(textBox3.Text);

            bssuser.InsertarProveeBss(provee);
            MessageBox.Show("Provee registrado");
        }
    }
}
