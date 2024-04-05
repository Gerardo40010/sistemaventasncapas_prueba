using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.PersonaVistas;
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
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.IdCliente = IdClienteSeleccionado;
            venta.IdVendedor = IdUsuarioSeleccionado;
            venta.Fecha = dateTimePicker1.Value;
            venta.Total = Convert.ToDecimal(textBox3.Text);
            venta.Estado = textBox4.Text;

            bss.InsertarVentaBss(venta);
            MessageBox.Show("Se guardo correctamente la Venta");
        }

        public static int IdClienteSeleccionado = 0;
        ClienteBss bsscliente = new ClienteBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bsscliente.ObtenerClienteIdBss(IdClienteSeleccionado);
                textBox1.Text = Convert.ToString(cliente.IdCliente);
            }
        }

        public static int IdUsuarioSeleccionado = 0;
        UsuarioBss bssusuario = new UsuarioBss();
        private void button4_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssusuario.ObtenerUsuarioIdBss(IdUsuarioSeleccionado);
                textBox2.Text = usuario.NombreUser;
            }
        }
    }
}
