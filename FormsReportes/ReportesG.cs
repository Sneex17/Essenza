using Microsoft.Reporting.WinForms;
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
    public partial class Reportes : Form
    {
        string rt;
        string ds;
        object Datos;
        public Reportes(string DataSet, string ruta, object datos)
        {
            InitializeComponent();
            rt = ruta;
            ds = DataSet;
            Datos = datos;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

            this.reportViewerGeneral.RefreshReport();
            reportViewerGeneral.LocalReport.ReportPath = rt;
            reportViewerGeneral.LocalReport.DataSources.Clear();
            reportViewerGeneral.LocalReport.DataSources.Add(new ReportDataSource(ds, Datos));
            reportViewerGeneral.RefreshReport();

        }

        private void BuExit_Click(object sender, EventArgs e) => this.Close();
       
    }
}
