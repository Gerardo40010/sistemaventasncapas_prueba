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
        Usuario usuario = new Usuario();
        UsuarioBss bss = new UsuarioBss();
        public UsuarioEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void UsuarioEditarVista_Load(object sender, EventArgs e)
        {
            usuario = bss.ObtenerUsuarioIdBss(idx);
            textBox1.Text = Convert.ToString(usuario.IdPersona);
            textBox2.Text = usuario.NombreUser;
            textBox3.Text = usuario.Contraseña;
            dateTimePicker1.Value = usuario.FechaReg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser = textBox2.Text;
            usuario.Contraseña = textBox3.Text;
            usuario.FechaReg = dateTimePicker1.Value;

            bss.EditarUsuarioBss(usuario);
            MessageBox.Show("Datos Actualizados");
        }

        public static int IdPersonaSeleccionada = 0;
        PersonaBss bsspersona = new PersonaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bsspersona.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
