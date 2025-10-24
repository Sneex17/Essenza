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

namespace Essenza.FormsVentasYFacturas
{
    public partial class FormPagoEfectivo : Form
    {
        int idCliente, idPago;
        DateTime fecha;
        public FormPagoEfectivo(Facturas facturas)
        {
            InitializeComponent();
            lbTotal.Text = $"{facturas.total_pagado.ToString()}";
            idCliente = facturas.id_cliente;
            idPago = facturas.id_metodo_pago;
            fecha = facturas.fecha_venta;

        }

        private void BuPagarFinal_Click(object sender, EventArgs e)
        {
            
            decimal devuelta = 0;
            decimal PagoCon = Convert.ToDecimal(txtEfectivo.Text);
            string Efectivo = lbTotal.Text;
            decimal Total = Convert.ToDecimal(Efectivo);

            if (PagoCon >= Total)
            {
                devuelta = PagoCon - Total;
                Facturas facturas = new Facturas();

                facturas.id_cliente = idCliente;
                facturas.fecha_venta = fecha;
                facturas.id_metodo_pago = idPago;
                facturas.total_pagado = Total;
                Facturas.PagoRealizado(facturas);
                DetallesFacturas detallesFacturas = new DetallesFacturas();
                detallesFacturas.id_factura = Facturas.IdFactura(facturas);
                detallesFacturas.id_cliente = facturas.id_cliente;
                detallesFacturas.descripcion = "Pago realizado con exito";
                DetallesFacturas.FinProcesoPago(detallesFacturas);

                MessageBox.Show($"Pago realizado con exito!\nPreciototal: ${Total}" +
                    $"\nDevolucion: ${devuelta}", "Pago realizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                var condicionPago = MessageBox.Show($"Necesitas mas efectivo para pagar\nAgregar mas " +
                    $"efectivo: SI\nCancelar pago: NO", "Pago en Proceso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(condicionPago == DialogResult.No)
                {
                    DetallesFacturas detallesFacturas = new DetallesFacturas();
                    detallesFacturas.id_cliente = idCliente;
                    detallesFacturas.fecha_venta = fecha;
                    DetallesFacturas.PagoCancelado(detallesFacturas);
                    this.Close();
                }

            }
            
        }
    }
}
