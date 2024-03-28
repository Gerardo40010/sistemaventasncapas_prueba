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

namespace SistemasVentas.VISTA.ProveeVista
{
    public partial class ProveeInsertarVista : Form
    {
        public ProveeInsertarVista()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Provee p = new Provee();
            p.IdProducto=Convert.ToInt32(textBox1.Text);
            p.IdProveedor=Convert.ToInt32(textBox2.Text);
            p.Fecha = dateTimePicker1.Value;
            p.Precio=Convert.ToDecimal(textBox4.Text);

            bss.InsertarProveeBss(p);
            MessageBox.Show("se guardo correctamente provee");
        }
    }
}
