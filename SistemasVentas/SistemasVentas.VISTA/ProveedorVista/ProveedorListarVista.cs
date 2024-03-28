using SistemasVentas.BSS;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.ProveeVistas;
using SistemasVentas.VISTA.UsuarioRolVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveedorVista
{
    public partial class ProveedorListarVista : Form
    {
        public ProveedorListarVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void ProveedorListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProveeInsertarVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            IngresoInsertarVistas.IdProveedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
