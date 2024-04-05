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
        Marca marca = new Marca();
        MarcaBss bss = new MarcaBss();
        public MarcaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void MarcaEditarVista_Load(object sender, EventArgs e)
        {
            marca = bss.ObtenerMarcaIdBss(idx);
            textBox1.Text = marca.Nombre;
            textBox2.Text = marca.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marca.Nombre = textBox1.Text;
            marca.Estado = textBox2.Text;

            bss.EditarMarcaBss(marca);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
