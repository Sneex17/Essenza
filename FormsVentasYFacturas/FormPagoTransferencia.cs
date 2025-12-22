using Essenza.Clases;
using Essenza.ClasesAR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Essenza.FormsVentasYFacturas
{
    //Pago por Transferencia
    public partial class FormPagoTransferencia : Form
    {
        //Variables y listas para almacenar los datos
        private CancellationTokenSource Cancelar;
        
        int idCliente, idPago, idFactura;
        DateTime fecha;
        List<Inventarios> listaCantidad;
        List<DetallesFacturas> listFact;

        public FormPagoTransferencia(Facturas facturas, Object lista, List<DetallesFacturas> listaFactura)
        {
            InitializeComponent();
            lbTotal.Text = $"{facturas.total_pagado.ToString()}";
            idCliente = facturas.id_cliente;
            idPago = facturas.id_metodo_pago;
            fecha = facturas.fecha_venta;
            listaCantidad = (List<Inventarios>)lista;
            listFact = listaFactura;
            pbProcesando.Visible = false;
            BuCancelar.Enabled = false;
        }

        //Metodo para la imprimir la factura
        private void ImprimirFactura(object sender, PrintPageEventArgs t)
        {
            Imprimir.ImprimirFacturaPDF(listFact, t, idPago, idFactura);
        }

        //Metedo de pago final
        private async void BuPagarFinal_Click(object sender, EventArgs e)
        {
            Cancelar = new CancellationTokenSource();
            BuCancelar.Enabled = true;
            pbProcesando.Visible = true;
            try
            {
                for (int i = 0; i <= 100; i++)
                {
                    //Uso de Async/Await
                    Cancelar.Token.ThrowIfCancellationRequested();
                    await Task.Delay(75, Cancelar.Token); 
                    pbProcesando.Value = i; 
                }

            }
            catch (OperationCanceledException)
            {
                MessageBox.Show($"Pago cancelado", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            

            //Barra de progreso
            if(pbProcesando.Value == 100)
            {
                string Efectivo = lbTotal.Text;
                decimal Total = Convert.ToDecimal(Efectivo);
                Facturas facturas = new Facturas();

                facturas.id_cliente = idCliente;
                facturas.fecha_venta = fecha;
                facturas.id_metodo_pago = idPago;
                facturas.total_pagado = Total;
                Facturas.PagoRealizado(facturas);
                DetallesFacturas detallesFacturas = new DetallesFacturas();
                detallesFacturas.id_factura = Facturas.IdFactura(facturas);
                idFactura = detallesFacturas.id_factura;
                detallesFacturas.id_cliente = facturas.id_cliente;
                detallesFacturas.descripcion = "Pago realizado con exito";
                DetallesFacturas.FinProcesoPago(detallesFacturas);

                int cantiadadActual;
                foreach (var list in listaCantidad)
                {
                    Inventarios inventarios = new Inventarios();
                    inventarios.id_inventario = list.id_inventario;
                    cantiadadActual = Convert.ToInt32(Inventarios.cantidadActual(inventarios));
                    inventarios.cantidad = cantiadadActual - list.cantidad;
                    Inventarios.UpdateStok(inventarios);
                }

                MessageBox.Show($"Pago realizado con exito!", "Pago realizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                //Imprecion de la Factura
                printTransferencia = new PrintDocument();
                PrinterSettings Styles = new PrinterSettings();
                printTransferencia.PrinterSettings = Styles;
                printTransferencia.PrintPage += ImprimirFactura;
                printTransferencia.Print();
            }

            
        }
        //Boton de cancelar transferencia
        private void BuCancelar_Click(object sender, EventArgs e)
        {
            Cancelar?.Cancel();
            if(pbProcesando.Value < 100)
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
