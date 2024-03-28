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

namespace SistemasVentas.VISTA.MarcaVista
{
    public partial class MarcaInsertarVista : Form
    {
        public MarcaInsertarVista()
        {
            InitializeComponent();
        }
        MarcaBss bss= new MarcaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Marca m= new Marca();
            m.Nombre=textBox1.Text;

            bss.InsertarMarcaBss(m);
            MessageBox.Show("se guardo correctamente marca");
        }
    }
}
