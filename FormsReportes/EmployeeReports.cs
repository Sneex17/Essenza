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

namespace Essenza.Forms
{
    public partial class EmployeeReports : Form
    {
        public event Action<Empleados> EmpleadoSelecionado;
        public EmployeeReports()
        {
            InitializeComponent();
            DatosEmp();
        }

        private void DatosEmp()
        {
            Empleados empleados = new Empleados();
            dataReportsInventarios.DataSource = Empleados.DatosReportsE();
            cbxFilroInventarios.DataSource = empleados.ListDatosFiltro;
        }


        private void dataReportsE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Empleados employees = new Empleados
                {
                    id_empleado = Convert.ToInt32(dataReportsInventarios.Rows[e.RowIndex].Cells["id_empleado"].Value),
                    nombres = dataReportsInventarios.Rows[e.RowIndex].Cells["nombres"].Value.ToString(),
                    apellidos = dataReportsInventarios.Rows[e.RowIndex].Cells["apellidos"].Value.ToString(),
                    id_sexo = Convert.ToInt32(dataReportsInventarios.Rows[e.RowIndex].Cells["id_sexo"].Value),
                    id_estado_civil = Convert.ToInt32(dataReportsInventarios.Rows[e.RowIndex].Cells["id_estado_civil"].Value),
                    fecha_nacimiento = Convert.ToDateTime(dataReportsInventarios.Rows[e.RowIndex].Cells["fecha_nacimiento"].Value),
                    edad = Convert.ToInt32(dataReportsInventarios.Rows[e.RowIndex].Cells["edad"].Value),
                    fecha_contrato = Convert.ToDateTime(dataReportsInventarios.Rows[e.RowIndex].Cells["fecha_contrato"].Value),
                    telefono = dataReportsInventarios.Rows[e.RowIndex].Cells["telefono"].Value.ToString(),
                    email = dataReportsInventarios.Rows[e.RowIndex].Cells["email"].Value.ToString(),
                    direccion = dataReportsInventarios.Rows[e.RowIndex].Cells["direccion"].Value.ToString(),
                    id_cargo = Convert.ToInt32(dataReportsInventarios.Rows[e.RowIndex].Cells["id_cargo"].Value),
                    salario = Convert.ToDecimal(dataReportsInventarios.Rows[e.RowIndex].Cells["salario"].Value),
                    id_estado = Convert.ToInt32(dataReportsInventarios.Rows[e.RowIndex].Cells["id_estado"].Value)
                };
                EmpleadoSelecionado?.Invoke(employees);
                this.Close();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string campo = cbxFilroInventarios.SelectedItem?.ToString(); 
            string valor = txtFilterInventarios.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                DatosEmp(); 
            }
            else if (!string.IsNullOrEmpty(campo))
            {
                string NewQuery = "";

                if (campo == "id_empleado" || campo == "id_sexo" || campo == "id_estado_civil" ||
                    campo == "edad" || campo == "id_cargo" || campo == "salario" || campo == "id_estado")
                {
                    NewQuery = $"SELECT * FROM empleados WHERE {campo} LIKE '{valor}%'";
                }
                else
                {
                    NewQuery = $"SELECT * FROM empleados WHERE {campo} LIKE '{valor}%'";
                }
                dataReportsInventarios.DataSource = Empleados.DatosReportsEFiltro(NewQuery);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarExcel excel = new ExportarExcel();
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
            guardar.Title = "Guardar reporte como";
            guardar.FileName = "Reporte.xlsx";
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                excel.ruta = guardar.FileName;
                excel.column = dataReportsInventarios;
                excel.row = dataReportsInventarios;
                excel.RowCells = dataReportsInventarios.ColumnCount;
                ExportarExcel.exportarExcel(excel);
            }
            
            
        }


        private void BuBuscarFechas_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(cbxFechas.Text))
            {
                MessageBox.Show($"Debe elegir el tipo de fecha para filtar los datos", "Filtro por Fechas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (cbxFechas.Text)
                {
                    case "Contrato":
                        {
                            List<Empleados> list = Empleados.DatosReportsE();
                            var datosPorFechas = list.Where(n => n.fecha_contrato >= fechaInicio.Value &&
                            n.fecha_contrato <= fechaFin.Value).Select(n => n).ToList();

                            dataReportsInventarios.DataSource = datosPorFechas.ToList();
                        }
                        break;

                    case "Nacimiento":
                        {
                            List<Empleados> list = Empleados.DatosReportsE();
                            var datosPorFechas = list.Where(n => n.fecha_nacimiento >= fechaInicio.Value &&
                            n.fecha_nacimiento <= fechaFin.Value).Select(n => n).ToList();

                            dataReportsInventarios.DataSource = datosPorFechas.ToList();
                        }
                        break;
                }
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
                                List<Empleados> list = Empleados.DatosReportsE();
                                var datos = from n in list orderby n.nombres select n;
                                dataReportsInventarios.DataSource = datos.ToList();
                            }
                            break;

                        case "Apellidos":
                            {
                                List<Empleados> list = Empleados.DatosReportsE();
                                var datos = from n in list orderby n.apellidos select n;
                                dataReportsInventarios.DataSource = datos.ToList();
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
                                List<Empleados> list = Empleados.DatosReportsE();
                                var datos = from n in list orderby n.nombres descending select n;
                                dataReportsInventarios.DataSource = datos.ToList();
                            }
                            break;

                        case "Apellidos":
                            {
                                List<Empleados> list = Empleados.DatosReportsE();
                                var datos = from n in list orderby n.apellidos descending select n;
                                dataReportsInventarios.DataSource = datos.ToList();
                            }
                            break;

                    }
                }
            }
        }

        private void BuExit_Click(object sender, EventArgs e) => this.Close();

    }
}
