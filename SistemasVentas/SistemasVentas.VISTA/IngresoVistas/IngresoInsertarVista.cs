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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoInsertarVista : Form
    {
        public IngresoInsertarVista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();
            ingreso.IdProveedor = IdProveedorSeleccionado;
            ingreso.FechaIngreso = dateTimePicker1.Value;
            ingreso.Total = Convert.ToInt32(textBox3.Text);
            ingreso.Estado = textBox4.Text;

            bss.InsertarIngresoBss(ingreso);
            MessageBox.Show("Se guardo correctamente el Ingreso");
        }

        public static int IdProveedorSeleccionado = 0;
        ProveedorBss bssproveedor = new ProveedorBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bssproveedor.ObtenerProveedorIdBss(IdProveedorSeleccionado);
                textBox1.Text = proveedor.Nombre;
            }
        }
    }
}
