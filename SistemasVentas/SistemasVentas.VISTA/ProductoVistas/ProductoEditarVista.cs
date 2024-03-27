using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.MarcaVistas;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoEditarVista : Form
    {
        int idx = 0;
        Producto p = new Producto();
        ProductoBSS bss = new ProductoBSS();
        public static int IdTipoProdSeleccionada = 0;
        TipoProdBSS bsstip = new TipoProdBSS();
        public static int IdMarcaSeleccionada = 0;
        MarcaBSS bssmar = new MarcaBSS();
        public ProductoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProductoEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerProductoIdBss(idx);
            textBox1.Text = p.IdTipoProd.ToString();
            textBox2.Text = p.IdMarca.ToString();
            textBox3.Text = p.Nombre;
            textBox4.Text = p.CodigoBarra;
            textBox5.Text = p.Unidad.ToString();
            textBox6.Text = p.Descripcion;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TipoProdListarVistas fr = new TipoProdListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProd tipoprod = bsstip.ObtenerTipoProdIdBss(IdTipoProdSeleccionada);
                textBox1.Text = tipoprod.Nombre;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MarcaListarVistas fr = new MarcaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca marca = bssmar.ObtenerMarcaIdBss(IdMarcaSeleccionada);
                textBox2.Text = marca.Nombre;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdTipoProd = IdTipoProdSeleccionada;
            p.IdMarca = IdMarcaSeleccionada;
            p.Nombre = textBox3.Text;
            p.CodigoBarra = textBox4.Text;
            p.Unidad = Convert.ToInt32(textBox5.Text);
            p.Descripcion = textBox6.Text;

            bss.EditarProductoBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
