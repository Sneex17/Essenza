using DocumentFormat.OpenXml.Wordprocessing;
using Essenza.Clases;
using Essenza.ClasesAR;
using Essenza.Forms;
using Essenza.FormsReportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essenza.FormsVentasYFacturas
{
    public partial class FormVender : Form
    {
        public FormVender()
        {
            InitializeComponent();
        }

        private void BuExit_Click(object sender, EventArgs e) => this.Close();

        private void BuBuscarDatos_Click(object sender, EventArgs e)
        {
            if (radioButtonEmpleado.Checked)
            {
                EmployeeReports reporteEmp = new EmployeeReports();

                reporteEmp.EmpleadoSelecionado += (empleados) =>
                {
                    txtIdEmpFact.Text = empleados.id_empleado.ToString();
                    txtNameEmpFact.Text = empleados.nombres;
                    txtCargoEmpFact.Text = empleados.id_cargo.ToString();
                    txtEmailEmpFact.Text += empleados.email;

                };
                reporteEmp.ShowDialog();
            }
            if (radioButtonCliente.Checked)
            {
                ReportesClientes reportesClient = new ReportesClientes();

                reportesClient.ClienteSelecionado += (clientes) =>
                {
                    txtIdClientFact.Text = clientes.id_cliente.ToString();
                    txtCedulaClientFact.Text = clientes.cedula;
                    txtNameClientFact.Text = clientes.nombres;
                    txtPhoneClientFact.Text = clientes.telefono;
                };
                reportesClient.ShowDialog();
            }
            if (radioButtonProducto.Checked)
            {
                ReportesInventarios reportesInventarios = new ReportesInventarios();

                reportesInventarios.SelecionalInventario += (inventarios) =>
                {
                    txtIdProductFact.Text = inventarios.id_inventario.ToString();
                    txtNameProductFact.Text = inventarios.producto;
                    txtPventaProductFact.Text = inventarios.precio_venta.ToString();
                    txtSubTotalFact.Text = txtPventaProductFact.Text;
                };
                reportesInventarios.ShowDialog();
            }

        }

        private void ClearTxtProducts()
        {
            txtIdProductFact.Text = String.Empty;
            txtNameProductFact.Text = String.Empty;
            txtPventaProductFact.Text = String.Empty;
            txtSubTotalFact.Text = String.Empty;
            CantidadPorProducto.Value = 1;

        }
        private void CantidadPorProducto_ValueChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtPventaProductFact.Text))
            {
                decimal PrecioCantidad;
                decimal Precio = Convert.ToDecimal(txtPventaProductFact.Text);
                PrecioCantidad = Precio * CantidadPorProducto.Value;
                txtSubTotalFact.Text = PrecioCantidad.ToString();
            }
            
            
        }

        private void BuAddCarrito_Click(object sender, EventArgs e)
        {
            string IdC, IdE, IdP, cantidad, precioU, precioC;
            double itbis, subtotal;

            IdC = txtIdClientFact.Text;
            IdE = txtIdEmpFact.Text;
            IdP = txtIdProductFact.Text;
            cantidad = CantidadPorProducto.Value.ToString();
            precioU = txtPventaProductFact.Text;
            precioC = txtSubTotalFact.Text;

            itbis = (Convert.ToDouble(precioC) * 0.18) / 1.18;
            subtotal = Convert.ToDouble(precioC) + itbis;

            dataCarrito.Rows.Add(new object[] { IdC, IdE, IdP, cantidad, 
                precioU, precioC, Math.Round(itbis, 2), Math.Round(subtotal, 2), "Eliminar" });
            CalcularTotal();
            ClearTxtProducts();
            

        }

        private void dataCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex != dataCarrito.Columns["opcion"].Index)
                return;
                
            dataCarrito.Rows.RemoveAt(e.RowIndex);
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal Total = 0;

            foreach(DataGridViewRow row in dataCarrito.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[7].Value != null &&
                    decimal.TryParse(row.Cells[7].Value.ToString(),
                    out decimal subtotal)) { Total += subtotal; }

            }
            txtTotalFact.Text = Math.Round(Total,2).ToString();
        }

        private void BuPagar_Click(object sender, EventArgs e)
        {
            if(radioButtonEfectivo.Checked)
            {
                DateTime fechaHoy = DateTime.Now;
                foreach (DataGridViewRow carrito in dataCarrito.Rows)
                {
                    if (carrito.IsNewRow) continue;
                    DetallesFacturas detallesFacturas = new DetallesFacturas();
                    detallesFacturas.id_cliente = Convert.ToInt32(carrito.Cells[0].Value.ToString());
                    detallesFacturas.id_empleado = Convert.ToInt32(carrito.Cells[1].Value.ToString());
                    detallesFacturas.id_inventario = Convert.ToInt32(carrito.Cells[2].Value.ToString());
                    detallesFacturas.fecha_venta = fechaHoy;
                    detallesFacturas.descripcion = "Procesando Pago";
                    detallesFacturas.cantidad = Convert.ToInt32(carrito.Cells[3].Value.ToString());
                    detallesFacturas.precio_unitario = Convert.ToDecimal(carrito.Cells[4].Value.ToString());
                    detallesFacturas.precio_cantidad = Convert.ToDecimal(carrito.Cells[5].Value.ToString());
                    detallesFacturas.itbis = Convert.ToDecimal(carrito.Cells[6].Value.ToString());
                    detallesFacturas.subtotal = Convert.ToDecimal(carrito.Cells[7].Value.ToString());
                    DetallesFacturas.AddDetalleFactura(detallesFacturas);
                }

                Facturas facturas = new Facturas();
                facturas.id_cliente = Convert.ToInt32(txtIdClientFact.Text);
                facturas.fecha_venta = fechaHoy;
                facturas.id_metodo_pago = 1;
                facturas.total_pagado = Convert.ToDecimal(txtTotalFact.Text);
                FormPagoEfectivo PagoEfectivo = new FormPagoEfectivo(facturas);
                PagoEfectivo.ShowDialog();
            }
            if(radioButtonTransferencia.Checked)
            {

            }
           
        }
    }
}
