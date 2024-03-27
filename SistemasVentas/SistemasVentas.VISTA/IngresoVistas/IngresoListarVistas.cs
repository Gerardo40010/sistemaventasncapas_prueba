using SistemasVentas.BSS;
using SistemasVentas.VISTA.DetalleingVistas;
using SistemasVentas.VISTA.UsuarioVistas;
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
    public partial class IngresoListarVistas : Form
    {
        public IngresoListarVistas()
        {
            InitializeComponent();
        }
        IngresoBSS bss = new IngresoBSS();
        private void IngresoListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarIngresoBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleingInsertarVista.IdIngresoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleingEditarVista.IdIngresoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IngresoInsertarVista fr = new IngresoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarIngresoBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            IngresoEditarVista fr = new IngresoEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarIngresoBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Ingreso?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarIngresoBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListarIngresoBss();
            }
        }
    }
}
