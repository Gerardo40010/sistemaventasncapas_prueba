using SistemasVentas.BSS;
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
    public partial class DetalleingListarVistas : Form
    {
        public DetalleingListarVistas()
        {
            InitializeComponent();
        }
        DetalleingBSS bss = new DetalleingBSS();
        private void DetalleingListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetalleingBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleingInsertarVista fr = new DetalleingInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetalleingBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleingEditarVista fr = new DetalleingEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetalleingBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este DetalleIng?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleIngBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListarDetalleingBss();
            }
        }
    }
}
