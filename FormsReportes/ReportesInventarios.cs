using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Essenza.Clases;

namespace Essenza.FormsReportes
{
    public partial class ReportesInventarios : Form
    {
        public event Action<Inventarios> SelecionalInventario;
        public ReportesInventarios()
        {
            InitializeComponent();
            ListaInventarios();
        }

        private void ListaInventarios()
        {
            dataListInventarios.DataSource = Inventarios.DatosInventarios();
        }

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
    }
}
