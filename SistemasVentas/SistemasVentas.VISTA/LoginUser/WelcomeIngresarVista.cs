using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.DetalleIngVistas;
using SistemasVentas.VISTA.DetalleVentaVistas;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.ProveedorVistas;
using SistemasVentas.VISTA.ProveeVistas;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.TipoProdVistas;
using SistemasVentas.VISTA.UsuarioRolVistas;
using SistemasVentas.VISTA.UsuarioVistas;
using SistemasVentas.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.LoginUser
{
    public partial class WelcomeIngresarVista : Form
    {
        public WelcomeIngresarVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista formulario = new PersonaListarVista();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioListarVista formulario = new UsuarioListarVista();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RolListarVista formulario = new RolListarVista();
            formulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsuarioRolListarVista formulario = new UsuarioRolListarVista();
            formulario.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ClienteListarVista formulario = new ClienteListarVista();
            formulario.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VentaListarVista formulario = new VentaListarVista();
            formulario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProveedorListarVista formulario = new ProveedorListarVista();
            formulario.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProveeListarVista formulario = new ProveeListarVista();
            formulario.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TipoProdListarVista formulario = new TipoProdListarVista();
            formulario.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MarcaListarVista formulario = new MarcaListarVista();
            formulario.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IngresoListarVista formulario = new IngresoListarVista();
            formulario.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ProductoListarVista formulario = new ProductoListarVista();
            formulario.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DetalleVentaListarVista formulario = new DetalleVentaListarVista();
            formulario.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DetalleIngListarVista formulario = new DetalleIngListarVista();
            formulario.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WelcomeIngresarVista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PersonaListarVista formulario = new PersonaListarVista();
            formulario.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UsuarioListarVista formulario = new UsuarioListarVista();
            formulario.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            ClienteListarVista formulario = new ClienteListarVista();
            formulario.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ProveedorListarVista formulario = new ProveedorListarVista();
            formulario.Show();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            ProductoListarVista formulario = new ProductoListarVista();
            formulario.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            IngresoListarVista formulario = new IngresoListarVista();
            formulario.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            RolListarVista formulario = new RolListarVista();
            formulario.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            VentaListarVista formulario = new VentaListarVista();
            formulario.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            ProveeListarVista formulario = new ProveeListarVista();
            formulario.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            TipoProdListarVista formulario = new TipoProdListarVista();
            formulario.Show();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            DetalleIngListarVista formulario = new DetalleIngListarVista();
            formulario.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            UsuarioRolListarVista formulario = new UsuarioRolListarVista();
            formulario.Show();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            DetalleVentaListarVista formulario = new DetalleVentaListarVista();
            formulario.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            MarcaListarVista formulario = new MarcaListarVista();
            formulario.Show();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
