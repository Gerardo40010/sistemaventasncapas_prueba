using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.PersonaVista
{
    public partial class PersonaEditarVista : Form
    {
        int idx = 0;
        Persona p = new Persona();
        PersonaBss bss = new PersonaBss();
        public PersonaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Apellido;
            textBox3.Text = p.Telefono;
            textBox4.Text = p.Ci;
            textBox5.Text = p.Correo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Nombre= textBox1.Text;
            p.Apellido= textBox2.Text;
            p.Telefono= textBox3.Text;
            p.Ci= textBox4.Text;
            p.Correo= textBox5.Text;

            bss.EditarPersonaBss(p);
            MessageBox.Show("Datos actualizados");
        }
    }
}
