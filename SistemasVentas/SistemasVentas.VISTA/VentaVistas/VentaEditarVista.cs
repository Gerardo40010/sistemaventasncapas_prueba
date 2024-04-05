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

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaEditarVista : Form
    {
        int idx = 0;
        Venta venta = new Venta();
        VentaBss bss = new VentaBss();
        public VentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void VentaEditarVista_Load(object sender, EventArgs e)
        {
            venta = bss.ObtenerVentaIdBss(idx);
            textBox1.Text = Convert.ToString(venta.IdCliente);
            textBox2.Text = Convert.ToString(venta.IdVendedor);
            dateTimePicker1.Value = Convert.ToDateTime(venta.Fecha);
            textBox3.Text = Convert.ToString(venta.Total);
            textBox4.Text = venta.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            venta.IdCliente = IdClienteSeleccionado;
            venta.IdVendedor = IdUsuarioSeleccionado;
            venta.Fecha = dateTimePicker1.Value;
            venta.Total = Convert.ToDecimal(textBox3.Text);
            venta.Estado = textBox4.Text;

            bss.EditarVentaBss(venta);
            MessageBox.Show("Datos Actualizados");
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
