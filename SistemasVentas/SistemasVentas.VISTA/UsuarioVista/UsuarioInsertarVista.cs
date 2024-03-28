using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioVista
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
            Usuario u = new Usuario();
            u.IdPersona = Convert.ToInt32(textBox1.Text);
            u.NombreUser = textBox2.Text;
            u.Contraseña = textBox3.Text;
            u.FechaReg = dateTimePicker1.Value;

            bss.InsertarUsuarioBss(u);
            MessageBox.Show("se guardo correctamente el usuario");
        }
    }
}
