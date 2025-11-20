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
            DetallesFacturas detallesFacturas = new DetallesFacturas();
            detallesFacturas.id_factura = Convert.ToInt32(dataFacturas.Rows[e.RowIndex].Cells["id_factura"].Value);
            List<DetallesFacturas> list = DetallesFacturas.datosDetallesFactura();
            var Detalles = from f in list where(f.id_factura == detallesFacturas.id_factura) select f;
            dataDetallesFacturas.DataSource = Detalles.ToList();
        }

        //Salir de la ventana
        private void BuExit_Click(object sender, EventArgs e) => this.Close();
    }
}
