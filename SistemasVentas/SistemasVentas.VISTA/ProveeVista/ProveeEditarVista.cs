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

namespace SistemasVentas.VISTA.ProveeVista
{

    public partial class ProveeEditarVista : Form
    {
        int idx = 0;
        Provee p = new Provee();
        ProveeBss bss = new ProveeBss();
        public ProveeEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProveeEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIdBss(idx);
            textBox1.Text = p.IdProducto.ToString();
            textBox2.Text = p.IdProveedor.ToString();
            dateTimePicker1.Value = p.Fecha;
            textBox4.Text = p.Precio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdProducto = Convert.ToInt32(textBox1.Text);
            p.IdProveedor = Convert.ToInt32(textBox2.Text);
            p.Fecha = dateTimePicker1.Value;
            p.Precio = Convert.ToDecimal(textBox4.Text);


            bss.EditarProveeBss(p);
            MessageBox.Show("Datos actualizados");
        }
    }
}
