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
    public partial class ReportesInventarios : Form
    {
        //Evento para mover los datos
        public event Action<Inventarios> SelecionalInventario;
        public ReportesInventarios()
        {
            InitializeComponent();
            ListaInventarios();
        }

        //Datos del DataGridView
        private void ListaInventarios()
        {
            Inventarios inventarios = new Inventarios();
            dataListInventarios.DataSource = Inventarios.DatosInventarios();
            cbxFilroInventarios.DataSource = inventarios.listDatosCbx;
        }

        //Accion de mover los datos
        private void dataListInventarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Inventarios inventarios = new Inventarios()
                {
                    id_inventario = Convert.ToInt32(dataListInventarios.Rows[e.RowIndex].Cells["id_inventario"].Value),
                    id_suplidor = Convert.ToInt32(dataListInventarios.Rows[e.RowIndex].Cells["id_suplidor"].Value),
                    producto = dataListInventarios.Rows[e.RowIndex].Cells["producto"].Value.ToString(),
                    descripcion = dataListInventarios.Rows[e.RowIndex].Cells["descripcion"].Value.ToString(),
                    cantidad = Convert.ToInt32(dataListInventarios.Rows[e.RowIndex].Cells["cantidad"].Value),
                    precio_compra = Convert.ToDecimal(dataListInventarios.Rows[e.RowIndex].Cells["precio_compra"].Value),
                    precio_venta = Convert.ToDecimal(dataListInventarios.Rows[e.RowIndex].Cells["precio_venta"].Value),
                    id_categoria = Convert.ToInt32(dataListInventarios.Rows[e.RowIndex].Cells["id_categoria"].Value),
                    fecha_ingreso = Convert.ToDateTime(dataListInventarios.Rows[e.RowIndex].Cells["fecha_ingreso"].Value)

                };
                SelecionalInventario?.Invoke(inventarios);
                this.Close();
            }
            
        }
        
        //Filtros de datos
        private void txtFilterInventarios_TextChanged(object sender, EventArgs e)
        {
            string campo = cbxFilroInventarios.SelectedItem?.ToString();
            string valor = txtFilterInventarios.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                ListaInventarios();
            }
            else if (!string.IsNullOrEmpty(campo))
            {
                string NewQuery = "";

                if (campo == "id_inventario" || campo == "id_suplidor" || campo == "cantidad" || 
                    campo == "id_categoria" || campo == "precio_compra" || campo == "precio_venta")
                {
                    NewQuery = $"SELECT * FROM inventarios WHERE {campo} LIKE '{valor}%'";
                }
                else
                {
                    NewQuery = $"SELECT * FROM inventarios WHERE {campo} LIKE '{valor}%'";
                }
                dataListInventarios.DataSource = Inventarios.ListaFiltroInventarios(NewQuery);
            }
        }
        private void BuBuscarFechas_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbxFechas.Text))
            {
                MessageBox.Show($"Debe elegir el tipo de fecha para filtar los datos", "Filtro por Fechas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (cbxFechas.Text)
                {
                    case "Ingreso":
                        {
                            List<Inventarios> list = Inventarios.DatosInventarios();
                            var datosPorFechas = list.Where(n => n.fecha_ingreso >= fechaInicio.Value &&
                            n.fecha_ingreso <= fechaFin.Value).Select(n => n).ToList();

                            dataListInventarios.DataSource = datosPorFechas.ToList();
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
                        case "Productos":
                            {
                                List<Inventarios> list = Inventarios.DatosInventarios();
                                var datos = from n in list orderby n.producto select n;
                                dataListInventarios.DataSource = datos.ToList();
                            }
                            break;
                    }
                }
                if (rBza.Checked)
                {
                    switch (cbxOrderBy.Text)
                    {
                        case "Productos":
                            {
                                List<Inventarios> list = Inventarios.DatosInventarios();
                                var datos = from n in list orderby n.producto descending select n;
                                dataListInventarios.DataSource = datos.ToList();
                            }
                            break;
                    }
                }
            }
        }
        //Boton de General reportes
        private void BuGeneralReporte_Click(object sender, EventArgs e)
        {
            List<Inventarios> DsInv = new List<Inventarios>();
            foreach (DataGridViewRow lista in dataListInventarios.Rows)
            {
                Inventarios inventarios = new Inventarios();
                inventarios.id_inventario = Convert.ToInt32(lista.Cells[0].Value.ToString());
                inventarios.id_suplidor = Convert.ToInt32(lista.Cells[1].Value.ToString());
                inventarios.producto = lista.Cells[2].Value.ToString();
                inventarios.cantidad = Convert.ToInt32(lista.Cells[4].Value.ToString());
                inventarios.precio_compra = Convert.ToDecimal(lista.Cells[5].Value.ToString());
                inventarios.precio_venta = Convert.ToDecimal(lista.Cells[6].Value.ToString());
                inventarios.id_categoria = Convert.ToInt32(lista.Cells[7].Value.ToString());
                DsInv.Add(inventarios);
            }
            rutaReportes ruta = new rutaReportes();
            Reportes reportes = new Reportes("DsInventarios", $"{ruta.ruta}ReportInventarios.rdlc", DsInv, "Reporte de Inventarios");
            reportes.ShowDialog();
        }
        //Salir de la venana
        private void BuExit_Click(object sender, EventArgs e) => this.Close();

        
    }
}
