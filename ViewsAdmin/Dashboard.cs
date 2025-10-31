using Essenza.Clases;
using Essenza.ClasesAR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essenza.ViewsAdmin
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Estadisticas();
        }
        private void Estadisticas()
        {
            DatosUnderstock();
            DatosTotalRegistros();
            DatosTotalVentas();
        }
        private void DatosUnderstock()
        {
            List<Inventarios> list = Inventarios.DatosInventarios();

            var understock = from inventario in list where (inventario.cantidad <= 10) 
                             select new {inventario.id_inventario, inventario.producto, inventario.cantidad};
            dataProductsUnderstock.DataSource = understock.ToList();  
        }

        private void DatosTotalVentas()
        {
            List<Facturas> listFacturas = Facturas.DatosFacturas();
            LbCantidadVentas.Text = Convert.ToString(listFacturas.Count);
            decimal Total = 0;
            foreach(var ingresos in listFacturas)
            {
                Total += ingresos.total_pagado;
            }
            LbTotalVentas.Text = $"${Total.ToString()}";
        }

        private void DatosTotalRegistros()
        {
            LbCountEmpl.Text = Convert.ToString(Empleados.DatosReportsE().Count);
            LbCountClient.Text = Convert.ToString(Clientes.DatosClientes().Count);
            LbCountSupl.Text = Convert.ToString(Suplidores.ListaSuplidores().Count);
            LbCountProd.Text = Convert.ToString(Inventarios.DatosInventarios().Count);
        }
        private void BuExit_Click(object sender, EventArgs e) => this.Close();
        
    }
}
