using SistemasVentas.BSS;
using SistemasVentas.Modelos;
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

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoInsertarVista : Form
    {
        public IngresoInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdProveedorSeleccionado = 0;
        ProveedorBSS bssuser = new ProveedorBSS();
        IngresoBSS bss = new IngresoBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso i = new Ingreso();
            i.IdProveedor = IdProveedorSeleccionado;
            i.FechaIngreso = dateTimePicker1.Value;
            i.Total = Convert.ToDecimal(textBox2.Text);

            bss.InsertarIngresoBss(i);
            MessageBox.Show("Se guardo correctamente El ingreso");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor p = bssuser.ObtenerProveedorIdBss(IdProveedorSeleccionado);
                textBox1.Text = p.Nombre ;
            }
        }
    }
}
