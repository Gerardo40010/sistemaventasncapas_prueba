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
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser = textBox2.Text;
            usuario.Contraseña = textBox3.Text;
            usuario.FechaReg = dateTimePicker1.Value;

            bss.InsertarUsuarioBss(usuario);
            MessageBox.Show("Se guardo correctamente el Usuario");
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
