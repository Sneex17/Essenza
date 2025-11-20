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
        //variables generales
        string rt;
        string ds;
        object Datos;
        string nombreReporte;
        public Reportes(string DataSet, string ruta, object datos, string nombre)
        {
            InitializeComponent();
            rt = ruta;
            ds = DataSet;
            Datos = datos;
            nombreReporte = nombre;
        }

        //General reporte
        private void Reportes_Load(object sender, EventArgs e)
        {
            int num1, num2;
            string[] letras = {"A", "B", "C", "D", "D", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T","U", "V", "W", "X", "Y", "Z"};


            Random random = new Random();
            num1 = random.Next(0,25);
            num2 = random.Next(0, 25);

            this.reportViewerGeneral.RefreshReport();
            reportViewerGeneral.LocalReport.ReportPath = rt;
            reportViewerGeneral.LocalReport.DataSources.Clear();
            reportViewerGeneral.LocalReport.DataSources.Add(new ReportDataSource(ds, Datos));
            reportViewerGeneral.LocalReport.DisplayName = $"{nombreReporte} " +
                $"#{letras[num1]}{num1}{letras[num2]}{num2}";
            reportViewerGeneral.RefreshReport();

        }

        //Salir de la ventana
        private void BuExit_Click(object sender, EventArgs e) => this.Close();
       
    }
}
