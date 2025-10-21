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

namespace Essenza.Forms
{
    public partial class ReportesClientes : Form
    {
        public event Action<Clientes> ClienteSelecionado;
        public ReportesClientes()
        {
            InitializeComponent();
            DatosClientes();
        }
        private void DatosClientes()
        {
            dataReportsC.DataSource = Clientes.DatosClientes();
        }
        private void dataReportsE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                Clientes clientes = new Clientes()
                {
                    id_cliente = Convert.ToInt32(dataReportsC.Rows[e.RowIndex].Cells["id_cliente"].Value),
                    nombres = dataReportsC.Rows[e.RowIndex].Cells["nombres"].Value.ToString(),
                    apellidos = dataReportsC.Rows[e.RowIndex].Cells["apellidos"].Value.ToString(),
                    id_sexo = Convert.ToInt32(dataReportsC.Rows[e.RowIndex].Cells["id_sexo"].Value),
                    cedula = dataReportsC.Rows[e.RowIndex].Cells["cedula"].Value.ToString(),
                    id_estado_civil = Convert.ToInt32(dataReportsC.Rows[e.RowIndex].Cells["id_estado_civil"].Value),
                    telefono = dataReportsC.Rows[e.RowIndex].Cells["telefono"].Value.ToString(),
                    email = dataReportsC.Rows[e.RowIndex].Cells["email"].Value.ToString(),
                    direccion = dataReportsC.Rows[e.RowIndex].Cells["direccion"].Value.ToString(),
                    id_estado = Convert.ToInt32(dataReportsC.Rows[e.RowIndex].Cells["id_estado"].Value)
                };
                ClienteSelecionado?.Invoke(clientes);
                this.Close();
            }
        }
    }
}
