using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssuser = new PersonaBss();
        ClienteBSS bss = new ClienteBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona p = bssuser.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = p.Nombre + " " + p.Apellido;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.IdPersona= IdPersonaSeleccionada;
            c.TipoCliente = textBox2.Text;
            c.CodigoCliente = textBox3.Text;

            bss.InsertarClienteBss(c);
            MessageBox.Show("Se guardo correctamente El cliente");
        }
    }
}
