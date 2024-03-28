using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ClienteVista;
using SistemasVentas.VISTA.UsuarioVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaInsertarVistas : Form
    {
        public VentaInsertarVistas()
        {
            InitializeComponent();
        }
        public static int IdClienteSeleccionado = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ClienteBss bss = new ClienteBss();
            ClienteListarVista fr = new ClienteListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bss.ObtenerIdBss(IdClienteSeleccionado);
                textBox1.Text = cliente.IdCliente.ToString();
            }
        }

        public static int IdVendedorSeleccionado = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioBss bss = new UsuarioBss();
            UsuarioListarVista fr = new UsuarioListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bss.ObtenerIdBss(IdVendedorSeleccionado);
                textBox2.Text = usuario.IdUsuario.ToString();
            }
        }

        VentaBss bssuser = new VentaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.IdCliente = IdClienteSeleccionado;
            venta.IdVendedor = IdVendedorSeleccionado;     
            venta.Fecha = dateTimePicker1.Value;
            venta.Total = Convert.ToDecimal(textBox3.Text);

            bssuser.InsertarVentaBss(venta);
            MessageBox.Show("Venta registrado");
        }
    }
}
