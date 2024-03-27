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
    public partial class MarcaEditarVista : Form
    {
        int idx = 0;
        Marca m = new Marca();
        MarcaBSS bss = new MarcaBSS();
        public MarcaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void MarcaEditarVista_Load(object sender, EventArgs e)
        {
            m = bss.ObtenerMarcaIdBss(idx);
            textBox1.Text = m.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.Nombre = textBox1.Text;

            bss.EditarMarcaBss(m);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
