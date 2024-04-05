using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
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
    public partial class IngresoEditarVista : Form
    {
        int idx = 0;
        Ingreso ingreso = new Ingreso();
        IngresoBss bss = new IngresoBss();
        public IngresoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void IngresoEditarVista_Load(object sender, EventArgs e)
        {
            ingreso = bss.ObtenerIngresoIdBss(idx);
            textBox1.Text = Convert.ToString(ingreso.IdProveedor);
            dateTimePicker1.Value = ingreso.FechaIngreso;
            textBox3.Text = Convert.ToString(ingreso.Total);
            textBox4.Text = ingreso.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso.IdProveedor = IdProveedorSeleccionado;
            ingreso.FechaIngreso = dateTimePicker1.Value; ;
            ingreso.Total = Convert.ToDecimal(textBox3.Text);
            ingreso.Estado = textBox4.Text;

            bss.EditarIngresoBss(ingreso);
            MessageBox.Show("Datos Actualizados");
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
