using SistemasVentas.DAL;
using SistemasVentas.VISTA.GerenteVista;
using SistemasVentas.VISTA.LoginUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProvedorVista
{
    public partial class ProvedorInicioSesionVista : Form
    {
        public ProvedorInicioSesionVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (Conexion.VerificadorCredenciales3(usuario, contraseña))
            {
                MessageBox.Show("Iniciando sesion");
                CompraProductoVista guiaForm = new CompraProductoVista();
                guiaForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (Conexion.VerificadorCredenciales3(usuario, contraseña))
            {
                MessageBox.Show("Iniciando sesion");
                CompraProductoVista guiaForm = new CompraProductoVista();
                guiaForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
