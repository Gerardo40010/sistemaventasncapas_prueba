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

namespace SistemasVentas.VISTA.MarcaVistas
{
    public partial class MarcaInsertarVista : Form
    {
        public MarcaInsertarVista()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Nombre = textBox1.Text;
            marca.Estado = textBox2.Text;

            bss.InsertarMarcaBss(marca);
            MessageBox.Show("Se guardo correctamente la Marca");
        }
    }
}
