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

namespace SistemasVentas.VISTA.ProveedorVistas
{
    public partial class ProveedorInsertarVista : Form
    {
        public ProveedorInsertarVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Nombre = textBox1.Text;
            proveedor.Telefono = textBox2.Text;
            proveedor.Direccion = textBox3.Text;
            proveedor.Estado = textBox4.Text;

            bss.InsertarProveedorBss(proveedor);
            MessageBox.Show("Se guardo correctamente al Proveedor");
        }
    }
}
