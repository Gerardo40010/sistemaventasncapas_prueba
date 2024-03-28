using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA;
using SistemasVentas.VISTA.RolVista;
using SistemasVentas.VISTA.UsuarioVista;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInsertarVistas : Form
    {
        public UsuarioRolInsertarVistas()
        {
            InitializeComponent();
        }
        public static int IdUsuarioSeleccionado = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioBss bss = new UsuarioBss();
            UsuarioListarVista fr = new UsuarioListarVista();
            if(fr.ShowDialog()==DialogResult.OK)
            {
                Usuario usuario = bss.ObtenerIdBss(IdUsuarioSeleccionado);
                textBox1.Text = usuario.NombreUser;
            }
        }
        public static int IdRolSeleccionado = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            RolBss bss=new RolBss();
            RolListarVista fr = new RolListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Rol rol = bss.ObtenerIdBss(IdRolSeleccionado);
                textBox2.Text = rol.Nombre;
            }


        }
        UsuarioRolBss bssuser = new UsuarioRolBss();
        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioRol usuarioRol = new UsuarioRol();
            usuarioRol.IdUsuario = IdUsuarioSeleccionado;
            usuarioRol.IdRol = IdRolSeleccionado;
            usuarioRol.FechaAsigna = dateTimePicker1.Value;

            bssuser.InsertarUsuarioRolBss(usuarioRol);
            MessageBox.Show("Usuario registrado");

        }
    }
}
