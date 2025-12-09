using DocumentFormat.OpenXml.Wordprocessing;
using Essenza.Clases;
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
    public partial class ReportesSuplidores : Form
    {
        //Evento para mover los datos
        public event Action<Suplidores> SelecionalSuplidor;
        public ReportesSuplidores()
        {
            InitializeComponent();
            DatosSuplidores();
        }

        //Datos del DataGridView
        private void DatosSuplidores()
        {
            Suplidores suplidores = new Suplidores();   
            dataListSuplidores.DataSource = Suplidores.ListaSuplidores();
            cbxFilroSuplidores.DataSource = suplidores.listDatosCbx;
        }

        //Accion de mover los datos
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
                    id_estado = Convert.ToInt32(dataListSuplidores.Rows[e.RowIndex].Cells["id_estado"].Value),
                    RNC = dataListSuplidores.Rows[e.RowIndex].Cells["RNC"].Value.ToString()
                };
                SelecionalSuplidor?.Invoke(suplidores);
                this.Close();
            }
            
        }

        //Filtros de datos
        private void txtFilterSuplidores_TextChanged(object sender, EventArgs e)
        {
            string campo = cbxFilroSuplidores.SelectedItem?.ToString();
            string valor = txtFilterSuplidores.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                DatosSuplidores();
            }
            else if (!string.IsNullOrEmpty(campo))
            {
                string NewQuery = "";

                if (campo == "id_suplidor" || campo == "id_pais" || campo == "id_estado")
                {
                    NewQuery = $"SELECT * FROM suplidores WHERE {campo} LIKE '{valor}%'";
                }
                else
                {
                    NewQuery = $"SELECT * FROM suplidores WHERE {campo} LIKE '{valor}%'";
                }
                dataListSuplidores.DataSource = Suplidores.ListaFiltroSuplidores(NewQuery);
            }
        }
        private void BuOrdenar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbxOrderBy.Text))
            {
                MessageBox.Show($"Debe elegir el tipo de atributo para filtar los datos", "Filtro por Atributos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (rBaz.Checked)
                {
                    switch (cbxOrderBy.Text)
                    {
                        case "Nombres":
                            {
                                List<Suplidores> list = Suplidores.ListaSuplidores();
                                var datos = from n in list orderby n.nombres select n;
                                dataListSuplidores.DataSource = datos.ToList();
                            }
                            break;

                        case "Email":
                            {
                                List<Suplidores> list = Suplidores.ListaSuplidores();
                                var datos = from n in list orderby n.email select n;
                                dataListSuplidores.DataSource = datos.ToList();
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
                                List<Suplidores> list = Suplidores.ListaSuplidores();
                                var datos = from n in list orderby n.nombres descending select n;
                                dataListSuplidores.DataSource = datos.ToList();
                            }
                            break;

                        case "Email":
                            {
                                List<Suplidores> list = Suplidores.ListaSuplidores();
                                var datos = from n in list orderby n.email descending select n;
                                dataListSuplidores.DataSource = datos.ToList();
                            }
                            break;
                    }
                }
            }
        }
        //Boton de gerenal reporte
        private void BuGeneralReporte_Click(object sender, EventArgs e)
        {
            List<Suplidores> DsSupli = new List<Suplidores>();
            foreach (DataGridViewRow lista in dataListSuplidores.Rows)
            {
                Suplidores suplidores = new Suplidores();
                suplidores.id_suplidor = Convert.ToInt32(lista.Cells[0].Value.ToString());
                suplidores.nombres = lista.Cells[1].Value.ToString();
                suplidores.email = lista.Cells[3].Value.ToString();
                suplidores.id_pais = Convert.ToInt32(lista.Cells[5].Value.ToString());
                suplidores.id_estado = Convert.ToInt32(lista.Cells[6].Value.ToString());
                suplidores.RNC = lista.Cells[7].Value.ToString();
                DsSupli.Add(suplidores);
            }
            rutaReportes ruta = new rutaReportes();
            Reportes reportes = new Reportes("DsSuplidores", $"{ruta.ruta}ReportSuplidores.rdlc", DsSupli, "Reporte de Suplidores");
            reportes.ShowDialog();
        }

        //Salir de la ventana
        private void BuExit_Click(object sender, EventArgs e) => this.Close();

        
    }
}
