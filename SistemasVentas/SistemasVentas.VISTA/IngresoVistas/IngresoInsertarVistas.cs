using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVista;
using SistemasVentas.VISTA.ProveedorVista;
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

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoInsertarVistas : Form
    {
        public IngresoInsertarVistas()
        {
            InitializeComponent();
        }
        public static int IdProveedorSeleccionado = 0;
        ProveedorBss bss = new ProveedorBss();
        private void button1_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bss.ObtenerIdBss(IdProveedorSeleccionado);
                textBox1.Text = proveedor.IdProveedor.ToString();
            }
        }

        IngresoBss bssuser = new IngresoBss();
        private void button2_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();
            ingreso.IdProveedor = IdProveedorSeleccionado;
            ingreso.FechaIngreso = dateTimePicker1.Value;
            ingreso.Total = Convert.ToInt32(textBox2.Text);

            bssuser.InsertarIngresoBss(ingreso);
            MessageBox.Show("Ingreso registrado");
        }
    }
}

