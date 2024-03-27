using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.RolVistas;
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

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInsertarVista : Form
    {
        public UsuarioRolInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdUsuarioSeleccionado = 0;
        public static int IdRolSeleccionado = 0;
        UsuarioRolBSS bSS = new UsuarioRolBSS();
        UsuarioBSS bssuser = new UsuarioBSS();
        RolBss bssuser2 = new RolBss();

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol u = new UsuarioRol();
            u.IdUsuario = IdUsuarioSeleccionado;
            u.IdRol = IdRolSeleccionado;
            u.FechaAsigna = dateTimePicker1.Value;

            bSS.InsertarUsuarioRolBss(u);
            MessageBox.Show("Se guardo correctamente El Usuario Rol");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioListarVistas fr = new UsuarioListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario u = bssuser.ObtenerUsuarioIdBss(IdUsuarioSeleccionado);
                textBox1.Text = u.NombreUser;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RolListarVistas fr = new RolListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Rol r = bssuser2.ObtenerRolIdBss(IdRolSeleccionado);
                textBox2.Text = r.Nombre;
            }
        }
    }
}
