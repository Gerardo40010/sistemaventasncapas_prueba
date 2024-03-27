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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolEditarVista : Form
    {
        int idx = 0;
        UsuarioRol r = new UsuarioRol();
        UsuarioRolBSS bss = new UsuarioRolBSS();
        UsuarioBSS bssuser = new UsuarioBSS();
        RolBss bssrol = new RolBss();
        public static int IdUsuarioSeleccionada = 0;
        public static int IdRolSeleccionada = 0;
        public UsuarioRolEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void UsuarioRolEditarVista_Load(object sender, EventArgs e)
        {
            r = bss.ObtenerUsuarioRolIdBss(idx);
            textBox1.Text = r.IdUsuario.ToString();
            textBox2.Text = r.IdRol.ToString();
            dateTimePicker1.Value = r.FechaAsigna;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioListarVistas fr = new UsuarioListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssuser.ObtenerUsuarioIdBss(IdUsuarioSeleccionada);
                textBox1.Text = usuario.NombreUser;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RolListarVistas fr = new RolListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Rol rol = bssrol.ObtenerRolIdBss(IdRolSeleccionada);
                textBox2.Text = rol.Nombre;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r.IdUsuario = IdUsuarioSeleccionada;
            r.IdRol = IdRolSeleccionada;
            r.FechaAsigna = dateTimePicker1.Value;
            bss.EditarUsuarioRolBss(r);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
