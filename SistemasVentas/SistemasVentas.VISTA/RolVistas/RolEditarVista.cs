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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class RolEditarVista : Form
    {
        int idx = 0;
        Rol rol = new Rol();
        RolBss bss = new RolBss();
        public RolEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RolEditarVista_Load(object sender, EventArgs e)
        {
            rol = bss.ObtenerRolIdBss(idx);
            textBox1.Text = rol.Nombre;
            textBox2.Text = rol.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rol.Nombre = textBox1.Text;
            rol.Estado = textBox2.Text;

            bss.EditarRolBss(rol);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
