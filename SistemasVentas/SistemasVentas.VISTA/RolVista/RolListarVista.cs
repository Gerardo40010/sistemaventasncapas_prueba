using SistemasVentas.BSS;
using SistemasVentas.VISTA.PersonaVista;
using SistemasVentas.VISTA.UsuarioRolVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.RolVista
{
    public partial class RolListarVista : Form
    {
        public RolListarVista()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();
        private void RolListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarRolBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRolInsertarVistas.IdRolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RolInserVista fr = new RolInserVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarRolBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdRolSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            RolEditarVista fr = new RolEditarVista(IdRolSelecionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarRolBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdRolSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de elimar esta persona", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarRolBss(IdRolSelecionado);
                dataGridView1.DataSource = bss.ListarRolBss();
            }
        }
    }
}
