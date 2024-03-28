using SistemasVentas.BSS;
using SistemasVentas.VISTA.UsuarioVistas;
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
using SistemasVentas.VISTA.ClienteVistas;

namespace SistemasVentas.VISTA.PersonaVista
{
    public partial class PersonaListarVista : Form
    {
        public PersonaListarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void PersonaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonasBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioInsertarVistas.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteInsertarVistas.IdPersonaSeleccionada= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonaInsertarVista fr = new PersonaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPersonasBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdPersonaSelecionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PersonaEditarVista fr = new PersonaEditarVista(IdPersonaSelecionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource=bss.ListarPersonasBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdPersonaSelecionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de elimar esta persona","Eliminando",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarPersonaBss(IdPersonaSelecionada);
                dataGridView1.DataSource=bss.ListarPersonasBss();
            }
        }
    }
}
