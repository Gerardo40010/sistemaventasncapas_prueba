using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ClienteVista;
using SistemasVentas.VISTA.MarcaVista;
using SistemasVentas.VISTA.TipoProdVista;
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
    public partial class ProductoInsertarVistas : Form
    {
        public ProductoInsertarVistas()
        {
            InitializeComponent();
        }
        public static int IdTipoProdSeleccionado = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            TipoProdBss bss = new TipoProdBss();
            TipoProdListarVista fr = new TipoProdListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProd tipoProd = bss.ObtenerIdBss(IdTipoProdSeleccionado);
                textBox1.Text = tipoProd.Nombre;
            }
        }

        public static int IdMarcaSeleccionado = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            MarcaBss bss = new MarcaBss();
            MarcaListarVista fr = new MarcaListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca marca = bss.ObtenerIdBss(IdMarcaSeleccionado);
                textBox2.Text = marca.Nombre;
            }
        }

        ProductoBss bssuser = new ProductoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.IdTipoProd = IdTipoProdSeleccionado;
            producto.IdMarca = IdMarcaSeleccionado;
            producto.Nombre=textBox3.Text;
            producto.CodigoBarra = textBox4.Text;           
            producto.Unidad = Convert.ToInt32(textBox5.Text);
            producto.Descripcion = textBox6.Text;

            bssuser.InsertarProductoBss(producto);
            MessageBox.Show("Provee registrado");
        }
    }
}
