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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        Cliente cliente = new Cliente();
        ClienteBss bss = new ClienteBss();
        public ClienteEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            cliente = bss.ObtenerClienteIdBss(idx);
            textBox1.Text = Convert.ToString(cliente.IdPersona);
            textBox2.Text = cliente.TipoCliente;
            textBox3.Text = cliente.CodigoCliente;
            textBox4.Text = cliente.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.IdPersona = IdPersonaSeleccionada;
            cliente.TipoCliente = textBox2.Text;
            cliente.CodigoCliente = textBox3.Text;
            cliente.Estado = textBox4.Text;

            bss.EditarClienteBss(cliente);
            MessageBox.Show("Datos Actualizados");
        }

        public static int IdPersonaSeleccionada = 0;
        PersonaBss bsspersona = new PersonaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bsspersona.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
