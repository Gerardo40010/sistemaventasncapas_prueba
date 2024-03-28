using SistemasVentas.VISTA.GerenteVista;
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
            ProvedorListarVista listarVista = new ProvedorListarVista();
            listarVista.Show();
        }
    }
}
