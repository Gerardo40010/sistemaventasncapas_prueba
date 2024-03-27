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
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdClienteSeleccionado = 0;
        public static int IdVendedorSeleccionado = 0;
        VentaBSS bss = new VentaBSS();
        ClienteBSS bssuser = new ClienteBSS();
        UsuarioBSS bssven = new UsuarioBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta v = new Venta();
            v.IdCliente = IdClienteSeleccionado;
            v.IdVendedor = IdVendedorSeleccionado;
            v.Fecha = dateTimePicker1.Value;
            v.Total = Convert.ToDecimal(textBox3.Text);

            bss.InsertarVentaBss(v);
            MessageBox.Show("Se guardo correctamente La Venta");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVistas fr = new ClienteListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente c = bssuser.ObtenerClienteIdBss(IdClienteSeleccionado);
                textBox1.Text = c.TipoCliente;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsuarioListarVistas fr = new UsuarioListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssven.ObtenerUsuarioIdBss(IdVendedorSeleccionado);
                textBox2.Text = usuario.NombreUser;
            }
        }
    }
}
