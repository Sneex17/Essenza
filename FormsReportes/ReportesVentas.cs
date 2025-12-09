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

namespace Essenza.FormsReportes
{
    public partial class ReportesVentas : Form
    {
        DetallesFacturas detallesFacturas = new DetallesFacturas();
        public ReportesVentas()
        {
            InitializeComponent();
            DatosFacturas();
        }

        //Datos del DataGridView
        private void DatosFacturas()
        {
            dataFacturas.DataSource = Facturas.DatosFacturas();
        }

        //Datos detallados
        private void dataFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            try
            {
                
                detallesFacturas.id_factura = Convert.ToInt32(dataFacturas.Rows[e.RowIndex].Cells["id_factura"].Value);
                List<DetallesFacturas> list = DetallesFacturas.datosDetallesFactura();
                var Detalles = from f in list where (f.id_factura == detallesFacturas.id_factura) select f;
                dataDetallesFacturas.DataSource = Detalles.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //Boton de General reportes
        private void BuGeneralReporte_Click(object sender, EventArgs e)
        {
            try
            {
                List<Facturas> DsFact = new List<Facturas>();
                List<DetallesFacturas> DsDet = new List<DetallesFacturas>();

                foreach (DataGridViewRow lista in dataFacturas.Rows)
                {
                    Facturas facturas = new Facturas();
                    facturas.id_factura = Convert.ToInt32(lista.Cells[0].Value.ToString());
                    facturas.id_cliente = Convert.ToInt32(lista.Cells[1].Value.ToString());
                    facturas.fecha_venta = Convert.ToDateTime(lista.Cells[2].Value.ToString());
                    facturas.id_metodo_pago = Convert.ToInt32(lista.Cells[3].Value.ToString());
                    facturas.total_pagado = Convert.ToDecimal(lista.Cells[4].Value.ToString());

                    DsFact.Add(facturas);
                }

                foreach (DataGridViewRow listD in dataDetallesFacturas.Rows)
                {
                    DetallesFacturas detalles = new DetallesFacturas();
                    detalles.id_factura = Convert.ToInt32(listD.Cells[0].Value.ToString());
                    detalles.id_empleado = Convert.ToInt32(listD.Cells[2].Value.ToString());
                    detalles.id_inventario = Convert.ToInt32(listD.Cells[3].Value.ToString());
                    detalles.cantidad = Convert.ToInt32(listD.Cells[6].Value.ToString());
                    detalles.precio_unitario = Convert.ToDecimal(listD.Cells[7].Value.ToString());
                    detalles.precio_cantidad = Convert.ToDecimal(listD.Cells[8].Value.ToString());
                    detalles.itbis = Convert.ToDecimal(listD.Cells[9].Value.ToString());
                    detalles.subtotal = Convert.ToDecimal(listD.Cells[10].Value.ToString());
                    DsDet.Add(detalles);
                }

                rutaReportes ruta = new rutaReportes();
                Reportes reportes = new Reportes("DsVentas", "DsDetalles", $"{ruta.ruta}ReportVentas.rdlc", DsFact, DsDet, "Reporte de Ventas");
                reportes.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton ventas de hoy
        private void BuHoy_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime inicio = DateTime.Today;
                DateTime fin = DateTime.Now;
                List<Facturas> listFact = Facturas.DatosFacturas();
                var datos = from w in listFact where w.fecha_venta  >= inicio && w.fecha_venta <= fin select w;
                dataFacturas.DataSource = datos.ToList();

                List<DetallesFacturas> listDet = DetallesFacturas.datosDetallesFactura();
                var detalle = from r in listDet where r.fecha_venta >= inicio && r.fecha_venta <= fin select r;
                dataDetallesFacturas.DataSource = detalle.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Boton ventas este mes
        private void BuEsteM_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime inicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime fin = DateTime.Now;
                List<Facturas> listFact = Facturas.DatosFacturas();
                var datos = from w in listFact where w.fecha_venta >= inicio && w.fecha_venta <= fin select w;
                dataFacturas.DataSource = datos.ToList();

                List<DetallesFacturas> listDet = DetallesFacturas.datosDetallesFactura();
                var detalle = from r in listDet where r.fecha_venta >= inicio && r.fecha_venta <= fin select r;
                dataDetallesFacturas.DataSource = detalle.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Boton ventas este año
        private void BuEsteA_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime inicio = new DateTime(DateTime.Now.Year, 1, 1);
                DateTime fin = DateTime.Now;
                List<Facturas> listFact = Facturas.DatosFacturas();
                var datos = from w in listFact where w.fecha_venta >= inicio && w.fecha_venta <= fin select w;
                dataFacturas.DataSource = datos.ToList();

                List<DetallesFacturas> listDet = DetallesFacturas.datosDetallesFactura();
                var detalle = from r in listDet where r.fecha_venta >= inicio && r.fecha_venta <= fin select r;
                dataDetallesFacturas.DataSource = detalle.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton fechas custom
        private void BuFechaCustom_Click(object sender, EventArgs e)
        {
            try
            {
                var inicio = dateFechaDesde.Value;
                var fin = dateFechaHasta.Value;
                List<Facturas> listFact = Facturas.DatosFacturas();
                var datos = from w in listFact where w.fecha_venta >= inicio && w.fecha_venta <= fin select w;
                dataFacturas.DataSource = datos.ToList();

                List<DetallesFacturas> listDet = DetallesFacturas.datosDetallesFactura();
                var detalle = from r in listDet where r.fecha_venta >= inicio && r.fecha_venta <= fin select r;
                dataDetallesFacturas.DataSource = detalle.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Salir de la ventana
        private void BuExit_Click(object sender, EventArgs e) => this.Close();

        
    }
}
