using SistemasVentas.DAL;
using SistemasVentas.VISTA.LoginUser;
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

namespace SistemasVentas.VISTA.GerenteVista
{
    public partial class GerenteInicioSesionVista : Form
    {
        public GerenteInicioSesionVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerenteListarVista listarVista = new GerenteListarVista();
            listarVista.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (Conexion.VerificadorCredenciales(usuario, contraseña))
            {
                MessageBox.Show("Iniciando sesion");
                WelcomeIngresarVista gerenteForm = new WelcomeIngresarVista();
                gerenteForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
