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
            Clientes clientes = new Clientes();
            dataReportsC.DataSource = Clientes.DatosClientes();
            cbxFilroClientes.DataSource = clientes.ListDatosClientesFiltro;
        }
        private void dataReportsC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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


        private void BuExit_Click(object sender, EventArgs e) => this.Close();




        private void txtFilterClientes_TextChanged(object sender, EventArgs e)
        {
            string campo = cbxFilroClientes.SelectedItem?.ToString();
            string valor = txtFilterClientes.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                DatosClientes();
            }
            else if (!string.IsNullOrEmpty(campo))
            {
                string NewQuery = "";

                if (campo == "id_cliente" || campo == "id_sexo" || 
                    campo == "id_estado_civil" || campo == "id_estado")
                {
                    NewQuery = $"SELECT * FROM clientes WHERE {campo} LIKE '{valor}%'";
                }
                else
                {
                    NewQuery = $"SELECT * FROM clientes WHERE {campo} LIKE '{valor}%'";
                }
                dataReportsC.DataSource = Clientes.DatosReporteFiltroClientes(NewQuery);
            }
        }

        private void BuOrdenar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbxOrderBy.Text))
            {
                MessageBox.Show($"Debe elegir el tipo de atributo para filtar los datos", "Filtro por Atributos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            {
                if (rBaz.Checked)
                {
                    switch (cbxOrderBy.Text)
                    {
                        case "Nombres":
                            {
                                List<Clientes> list = Clientes.DatosClientes();
                                var datos = from n in list orderby n.nombres select n;
                                dataReportsC.DataSource = datos.ToList();
                            }
                            break;

                        case "Apellidos":
                            {
                                List<Clientes> list = Clientes.DatosClientes();
                                var datos = from n in list orderby n.apellidos select n;
                                dataReportsC.DataSource = datos.ToList();
                            }
                            break;

                    }

                }
                if (rBza.Checked)
                {
                    switch (cbxOrderBy.Text)
                    {
                        case "Nombres":
                            {
                                List<Clientes> list = Clientes.DatosClientes();
                                var datos = from n in list orderby n.nombres descending select n;
                                dataReportsC.DataSource = datos.ToList();
                            }
                            break;

                        case "Apellidos":
                            {
                                List<Clientes> list = Clientes.DatosClientes();
                                var datos = from n in list orderby n.apellidos descending select n;
                                dataReportsC.DataSource = datos.ToList();
                            }
                            break;

                    }
                }

            }
        }

        
    }
}
