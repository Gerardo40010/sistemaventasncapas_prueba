using SistemasVentas.BSS;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.VentaVistas;
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
    public partial class MarcaListarVista : Form
    {
        public MarcaListarVista()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void MarcaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarMarcaBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoInsertarVistas.IdMarcaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
