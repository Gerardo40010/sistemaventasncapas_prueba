using SistemasVentas.BSS;
using SistemasVentas.VISTA.DetalleIngVistas;
using SistemasVentas.VISTA.ProveeVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.IngresoVista
{
    public partial class IngresoListarVista : Form
    {
        public IngresoListarVista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void IngresoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarIngresoBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIngInsertarVistas.IdIngresoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
