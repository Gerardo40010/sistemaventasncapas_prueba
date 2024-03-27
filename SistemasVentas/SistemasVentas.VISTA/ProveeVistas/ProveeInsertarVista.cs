using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
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
    public partial class ProveeInsertarVista : Form
    {
        public ProveeInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdProductoSeleccionada = 0;
        public static int IdProveedorSeleccionado = 0;
        ProveeBSS bss = new ProveeBSS();
        ProductoBSS bssuser = new ProductoBSS();
        ProveedorBSS bssuser2 = new ProveedorBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            Provee p = new Provee();
            p.IdProducto = IdProductoSeleccionada;
            p.IdProveedor = IdProveedorSeleccionado;
            p.Fecha = dateTimePicker1.Value;
            p.Precio = Convert.ToDecimal(textBox3.Text);

            bss.InsertarProveeBss(p);
            MessageBox.Show("Se guardo correctamente El Proveedor");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto p = bssuser.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox1.Text = p.Nombre;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor p = bssuser2.ObtenerProveedorIdBss(IdProveedorSeleccionado);
                textBox2.Text = p.Nombre;
            }
        }
    }
}
