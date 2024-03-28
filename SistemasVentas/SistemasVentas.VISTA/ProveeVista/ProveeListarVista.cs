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
using SistemasVentas.VISTA.ProveeVista;

namespace SistemasVentas.VISTA.ProveeVista
{
    public partial class ProveeListarVista : Form
    {
        public ProveeListarVista()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void ProveeListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveeBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProveeInsertarVista  fr = new ProveeInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveeBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdProveeSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeEditarVista fr = new ProveeEditarVista(IdProveeSelecionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveeBss();
            }
        }
    }
}
