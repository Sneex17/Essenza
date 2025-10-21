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
        public event Action<Suplidores> SelecionalSuplidor;
        public ReportesSuplidores()
        {
            InitializeComponent();
            DatosSuplidores();
        }

        private void DatosSuplidores()
        {
            dataListSuplidores.DataSource = Suplidores.ListaSuplidores();
        }

        private void dataListSuplidores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                Suplidores suplidores = new Suplidores()
                {
                    id_suplidor = Convert.ToInt32(dataListSuplidores.Rows[e.RowIndex].Cells["id_suplidor"].Value),
                    nombres = dataListSuplidores.Rows[e.RowIndex].Cells["nombres"].Value.ToString(),
                    telefono = dataListSuplidores.Rows[e.RowIndex].Cells["telefono"].Value.ToString(),
                    email = dataListSuplidores.Rows[e.RowIndex].Cells["email"].Value.ToString(),
                    direccion = dataListSuplidores.Rows[e.RowIndex].Cells["direccion"].Value.ToString(),
                    id_pais = Convert.ToInt32(dataListSuplidores.Rows[e.RowIndex].Cells["id_pais"].Value),
                    id_estado = Convert.ToInt32(dataListSuplidores.Rows[e.RowIndex].Cells["id_estado"].Value)
                };
                SelecionalSuplidor?.Invoke(suplidores);
                this.Close();
            }
            
        }
    }
}
