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
        public FormPagoEfectivo(Facturas facturas)
        {
            InitializeComponent();
            lbTotal.Text = $"{facturas.total_pagado.ToString()}";
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
                MessageBox.Show($"Pago realizado con exito!\nPreciototal: ${Total}" +
                    $"\nDevolucion: ${Total}", "Pago realizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                var condicionPago = MessageBox.Show($"Necesitas mas efectivo para pagar\nAgregar mas efectivo: SI\nCancelar pago: NO", "Pago realizado",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(condicionPago == DialogResult.No)
                {
                    this.Close();
                }

            }
            
        }
    }
}
