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

namespace SistemasVentas.VISTA.ClienteVista
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c=new Cliente();
            c.IdPersona=Convert.ToInt32(textBox1.Text);
            c.TipoCliente=textBox2.Text;
            c.CodigoCliente=textBox3.Text;

            bss.InsertarClienteBss(c);
            MessageBox.Show("se guardo correctamente cliente");
        }
    }
}
