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
        ProductoBss bss = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.IdTipoProd = IdTipoProdSeleccionado;
            producto.IdMarca = IdMarcaSeleccionada;
            producto.Nombre = textBox3.Text;
            producto.CodigoBarra = textBox4.Text;
            producto.Unidad = Convert.ToInt32(textBox5.Text);
            producto.Descripcion = textBox6.Text;
            producto.Estado = textBox7.Text;

            bss.InsertarProductoBss(producto);
            MessageBox.Show("Se guardo correctamente el Producto");
        }

        public static int IdTipoProdSeleccionado = 0;
        TipoProdBss bsstipoProd = new TipoProdBss();
        private void button3_Click(object sender, EventArgs e)
        {
            TipoProdListarVista fr = new TipoProdListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProd tipoProd = bsstipoProd.ObtenerTipoProdIdBss(IdTipoProdSeleccionado);
                textBox1.Text = tipoProd.Nombre;
            }
        }

        public static int IdMarcaSeleccionada = 0;
        MarcaBss bssmarca = new MarcaBss();
        private void button4_Click(object sender, EventArgs e)
        {
            MarcaListarVista fr = new MarcaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca marca = bssmarca.ObtenerMarcaIdBss(IdMarcaSeleccionada);
                textBox2.Text = marca.Nombre;
            }
        }
    }
}
