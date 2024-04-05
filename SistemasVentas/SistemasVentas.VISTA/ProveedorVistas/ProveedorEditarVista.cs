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

namespace SistemasVentas.VISTA.ProveedorVistas
{
    public partial class ProveedorEditarVista : Form
    {
        int idx = 0;
        Proveedor proveedor = new Proveedor();
        ProveedorBss bss = new ProveedorBss();
        public ProveedorEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProveedorEditarVista_Load(object sender, EventArgs e)
        {
            proveedor = bss.ObtenerProveedorIdBss(idx);
            textBox1.Text = proveedor.Nombre;
            textBox2.Text = proveedor.Telefono;
            textBox3.Text = proveedor.Direccion;
            textBox4.Text = proveedor.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proveedor.Nombre = textBox1.Text;
            proveedor.Telefono = textBox2.Text;
            proveedor.Direccion = textBox3.Text;
            proveedor.Estado = textBox4.Text;

            bss.EditarProveedorBss(proveedor);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
