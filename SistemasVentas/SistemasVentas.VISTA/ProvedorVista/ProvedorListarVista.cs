using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProvedorVista
{
    public partial class ProvedorListarVista : Form
    {
        public ProvedorListarVista()
        {
            InitializeComponent();
        }

        private void ProvedorListarVista_Load(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            dataGridView1.DataSource = bss.ListarProductoBss();
        }
    }
}
