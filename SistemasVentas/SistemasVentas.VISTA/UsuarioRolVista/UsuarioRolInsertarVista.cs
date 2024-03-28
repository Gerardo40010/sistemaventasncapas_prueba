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

namespace SistemasVentas.VISTA.UsuarioRolVista
{
    public partial class UsuarioRolInsertarVista : Form
    {
        public UsuarioRolInsertarVista()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol ur = new UsuarioRol();
            ur.IdUsuario = Convert.ToInt32(textBox1.Text);
            ur.IdRol= Convert.ToInt32(textBox2.Text);
            ur.FechaAsigna=dateTimePicker1.Value;

            bss.InsertarUsuarioRolBss(ur);
            MessageBox.Show("se guardo correctamente UsuarioRol");
        }
    }
}
