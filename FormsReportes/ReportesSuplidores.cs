using Essenza.Clases;
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
    public partial class ReportesSuplidores : Form
    {
        public ReportesSuplidores()
        {
            InitializeComponent();
            DatosSuplidores();
        }

        private void DatosSuplidores()
        {
            dataListSuplidores.DataSource = Suplidores.ListaSuplidores();
        }
    }
}
