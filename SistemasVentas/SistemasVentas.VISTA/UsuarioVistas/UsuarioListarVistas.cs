using SistemasVentas.VISTA.UsuarioRolVistas;
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
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.VentaVistas;

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioListarVistas : Form
    {
        public UsuarioListarVistas()
        {
            InitializeComponent();
        }
        UsuarioBSS bss = new UsuarioBSS();
        private void UsuarioListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuarioBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRolInsertarVista.IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaInsertarVista.IdVendedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolEditarVista.IdUsuarioSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaEditarVista.IdVendedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioInsertarVista fr = new UsuarioInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuarioBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioEditarVista fr = new UsuarioEditarVista(IdUsuarioSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuarioBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a esta persona?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioBss(IdUsuarioSeleccionado);
                dataGridView1.DataSource = bss.ListarUsuarioBss();
            }
        }
    }
}
