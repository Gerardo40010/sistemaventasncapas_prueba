using SistemasVentas.VISTA.GerenteVista;
using SistemasVentas.VISTA.ProvedorVista;
using SistemasVentas.VISTA.VendedorVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.SistemaVentaVista
{
    public partial class SistemaVentaInicioVista : Form
    {
        public SistemaVentaInicioVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerenteInicioSesionVista listarvista = new GerenteInicioSesionVista();
            listarvista.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VendedorInicioSesionVista listarvista = new VendedorInicioSesionVista();
            listarvista.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProvedorInicioSesionVista listarvista = new ProvedorInicioSesionVista();
            listarvista.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GerenteInicioSesionVista listarvista = new GerenteInicioSesionVista();
            listarvista.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            VendedorInicioSesionVista listarvista = new VendedorInicioSesionVista();
            listarvista.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ProvedorInicioSesionVista listarvista = new ProvedorInicioSesionVista();
            listarvista.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           // VendedorInicioSesionVista listarvista = new VendedorInicioSesionVista();
           // listarvista.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GerenteInicioSesionVista listarvista = new GerenteInicioSesionVista();
            listarvista.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            VendedorInicioSesionVista listarvista = new VendedorInicioSesionVista();
             listarvista.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ProvedorInicioSesionVista listarvista = new ProvedorInicioSesionVista();
            listarvista.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            GerenteInicioSesionVista listarvista = new GerenteInicioSesionVista();
            listarvista.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            VendedorInicioSesionVista listarvista = new VendedorInicioSesionVista();
            listarvista.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ProvedorInicioSesionVista listarvista = new ProvedorInicioSesionVista();
            listarvista.Show();
        }
    }
}
