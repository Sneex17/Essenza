using Essenza.Clases;
using Essenza.Forms;
using Essenza.FormsReportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essenza.FormsVentasYFacturas
{
    public partial class FormVender : Form
    {
        public FormVender()
        {
            InitializeComponent();
        }

        private void BuExit_Click(object sender, EventArgs e) => this.Close();

        private void BuBuscarDatos_Click(object sender, EventArgs e)
        {
            if (radioButtonEmpleado.Checked)
            {
                EmployeeReports reporteEmp = new EmployeeReports();

                reporteEmp.EmpleadoSelecionado += (empleados) =>
                {
                    txtIdEmpFact.Text = empleados.id_empleado.ToString();
                    txtNameEmpFact.Text = empleados.nombres;
                    txtCargoEmpFact.Text = empleados.id_cargo.ToString();
                    txtEmailEmpFact.Text += empleados.email;

                };
                reporteEmp.ShowDialog();
            }
            if (radioButtonCliente.Checked)
            {
                ReportesClientes reportesClient = new ReportesClientes();

                reportesClient.ClienteSelecionado += (clientes) =>
                {
                    txtIdClientFact.Text = clientes.id_cliente.ToString();
                    txtCedulaClientFact.Text = clientes.cedula;
                    txtNameClientFact.Text = clientes.nombres;
                    txtPhoneClientFact.Text = clientes.telefono;
                };
                reportesClient.ShowDialog();
            }
            if (radioButtonProducto.Checked)
            {
                ReportesInventarios reportesInventarios = new ReportesInventarios();

                reportesInventarios.SelecionalInventario += (inventarios) =>
                {
                    txtIdProductFact.Text = inventarios.id_inventario.ToString();
                    txtNameProductFact.Text = inventarios.producto;
                    txtPventaProductFact.Text = inventarios.precio_venta.ToString();
                };
                reportesInventarios.ShowDialog();
            }

        }
    }
}
