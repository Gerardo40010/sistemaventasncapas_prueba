using SistemasVentas.BSS;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.DetalleIngVistas;
using SistemasVentas.VISTA.DetalleVentaVistas;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProveedorVistas;
using SistemasVentas.VISTA.ProveeVistas;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.TipoProdVistas;
using SistemasVentas.VISTA.UsuarioRolVistas;
using SistemasVentas.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioListarVista : Form
    {
        public UsuarioListarVista()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void UsuarioListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuariosBass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentaInsertarVista.IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaEditarVista.IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolEditarVista.IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolInsertarVista.IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioInsertarVista fr = new UsuarioInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuariosBass();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioEditarVista fr = new UsuarioEditarVista(IdUsuarioSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuariosBass();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas Seguro de eliminar este usuario?", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioBss(IdUsuarioSeleccionado);
                dataGridView1.DataSource = bss.ListarUsuariosBass();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!pMenu.Visible)
                pMenu.Visible = true;
            else
                pMenu.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClienteListarVista formulario = new ClienteListarVista();
            formulario.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RolListarVista formulario = new RolListarVista();
            formulario.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UsuarioRolListarVista formulario = new UsuarioRolListarVista();
            formulario.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PersonaListarVista formulario = new PersonaListarVista();
            formulario.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            VentaListarVista formulario = new VentaListarVista();
            formulario.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ProveedorListarVista formulario = new ProveedorListarVista();
            formulario.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ProveeListarVista formulario = new ProveeListarVista();
            formulario.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MarcaListarVista formulario = new MarcaListarVista();
            formulario.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TipoProdListarVista formulario = new TipoProdListarVista();
            formulario.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            IngresoListarVista formulario = new IngresoListarVista();
            formulario.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ProductoListarVista formulario = new ProductoListarVista();
            formulario.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DetalleVentaListarVista formulario = new DetalleVentaListarVista();
            formulario.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DetalleIngListarVista formulario = new DetalleIngListarVista();
            formulario.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
