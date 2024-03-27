using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
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

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioEditarVista : Form
    {
        int idx = 0;
        Usuario u = new Usuario();
        UsuarioBSS bss = new UsuarioBSS();
        PersonaBss bssuser = new PersonaBss();
        public static int IdPersonaSeleccionada = 0;
        public UsuarioEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona p = bssuser.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = p.Nombre + " " + p.Apellido;
            }
        }

        private void UsuarioEditarVista_Load(object sender, EventArgs e)
        {
            u = bss.ObtenerUsuarioIdBss(idx);
            textBox1.Text = u.IdPersona.ToString();
            textBox2.Text = u.NombreUser;
            textBox3.Text = u.Contraseña;
            dateTimePicker1.Value = u.FechaReg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.IdPersona = IdPersonaSeleccionada;
            u.NombreUser = textBox2.Text;
            u.Contraseña = textBox3.Text;
            u.FechaReg = dateTimePicker1.Value;

            bss.EditarUsuarioBss(u);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
