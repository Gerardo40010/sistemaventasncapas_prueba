﻿using SistemasVentas.BSS;
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
    public partial class VendeVentaListarVista : Form
    {
        public VendeVentaListarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void VendeVentaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentasBass();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentaInsertarVista fr = new VentaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentasBass();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaEditarVista fr = new VentaEditarVista(IdVentaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentasBass();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVentaEditarVista.IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaInsertarVista.IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!pMenu.Visible)
                pMenu.Visible = true;
            else
                pMenu.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VendeUsuarioListarVista formulario = new VendeUsuarioListarVista();
            formulario.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VendeRolListarVista formulario = new VendeRolListarVista();
            formulario.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VendeUsuarioRolListarVista formulario = new VendeUsuarioRolListarVista();
            formulario.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VendePersonaListarVista formulario = new VendePersonaListarVista();
            formulario.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            VendeClienteListarVista formulario = new VendeClienteListarVista();
            formulario.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VendeProveedorListarVista formulario = new VendeProveedorListarVista();
            formulario.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            VendeProveeListarVista formulario = new VendeProveeListarVista();
            formulario.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            VendeMarcaListarVista formulario = new VendeMarcaListarVista();
            formulario.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            VendeTipoProdListarVista formulario = new VendeTipoProdListarVista();
            formulario.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            VendeIngresoListarVista formulario = new VendeIngresoListarVista();
            formulario.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VendeProductoListarVista formulario = new VendeProductoListarVista();
            formulario.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            VendeDetalleVentaListarVista formulario = new VendeDetalleVentaListarVista();
            formulario.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            VendeDetalleIngListarVista formulario = new VendeDetalleIngListarVista();
            formulario.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VendeVentaListarVista_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentasBass();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            VentaInsertarVista fr = new VentaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentasBass();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaEditarVista fr = new VentaEditarVista(IdVentaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentasBass();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DetalleVentaEditarVista.IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaInsertarVista.IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
