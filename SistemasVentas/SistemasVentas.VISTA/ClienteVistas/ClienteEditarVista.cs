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
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        Cliente p = new Cliente();
        ClienteBSS bss = new ClienteBSS();
        PersonaBss bssper = new PersonaBss();
        public static int IdPersonaSeleccionada = 0;
        public ClienteEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerClienteIdBss(idx);
            textBox1.Text = p.IdPersona.ToString();
            textBox2.Text = p.TipoCliente;
            textBox3.Text = p.CodigoCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssper.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.IdPersona = IdPersonaSeleccionada;
            p.TipoCliente = textBox2.Text;
            p.CodigoCliente = textBox3.Text;

            bss.EditarClienteBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
