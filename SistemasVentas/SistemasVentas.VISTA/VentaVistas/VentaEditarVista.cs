using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.UsuarioVistas;
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

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaEditarVista : Form
    {
        int idx = 0;
        Venta p = new Venta();
        VentaBSS bss = new VentaBSS();
        public static int IdClienteSeleccionada = 0;
        ClienteBSS bssclie = new ClienteBSS();
        public static int IdVendedorSeleccionada = 0;
        UsuarioBSS bssven = new UsuarioBSS();
        public VentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void VentaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerVentaIdBss(idx);
            textBox1.Text = p.IdCliente.ToString();
            textBox2.Text = p.IdVendedor.ToString();
            dateTimePicker1.Value = p.Fecha;
            textBox3.Text = p.Total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVistas fr = new ClienteListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bssclie.ObtenerClienteIdBss(IdClienteSeleccionada);
                textBox1.Text = cliente.IdCliente.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsuarioListarVistas fr = new UsuarioListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssven.ObtenerUsuarioIdBss(IdVendedorSeleccionada);
                textBox2.Text = usuario.IdUsuario.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdCliente = IdClienteSeleccionada;
            p.IdVendedor = IdVendedorSeleccionada;
            p.Fecha = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox3.Text);
            bss.EditarVentaBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
