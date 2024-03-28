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

namespace SistemasVentas.VISTA.RolVista
{
    public partial class RolInserVista : Form
    {
        public RolInserVista()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Rol r = new Rol();
            r.Nombre = textBox1.Text;      

            bss.InsertarRolBss(r);
            MessageBox.Show("Se guardo correctamente el rol");
        }

      
    }
}
