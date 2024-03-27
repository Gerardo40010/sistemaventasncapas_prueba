using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.TipoProdVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoInsertarVista : Form
    {
        public ProductoInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdTipoProdSeleccionada = 0;
        public static int IdMarcaSeleccionada = 0;
        ProductoBSS bss = new ProductoBSS();
        TipoProdBSS bssuser = new TipoProdBSS();
        MarcaBSS bssuser2 = new MarcaBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.IdTipoProd = IdTipoProdSeleccionada;
            p.IdMarca = IdMarcaSeleccionada;
            p.Nombre = textBox3.Text;
            p.CodigoBarra = textBox4.Text;
            p.Unidad = Convert.ToInt32(textBox5.Text);
            p.Descripcion = textBox6.Text;

            bss.InsertarProductoBss(p);
            MessageBox.Show("Se guardo correctamente El Producto");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TipoProdListarVistas fr = new TipoProdListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProd t = bssuser.ObtenerTipoProdIdBss(IdTipoProdSeleccionada);
                textBox1.Text = t.Nombre;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MarcaListarVistas fr = new MarcaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca m = bssuser2.ObtenerMarcaIdBss(IdMarcaSeleccionada);
                textBox2.Text = m.Nombre;
            }
        }
    }
}
