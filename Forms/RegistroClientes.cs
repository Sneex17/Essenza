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
using System.Xml;

namespace Essenza.Forms
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
            txtIdC.Enabled = false;
            DatosCbx();
        }

        private void DatosCbx()
        {
            DatosSexos();
            DatosEstado();
            DatosEstadoCivil();
        }
        private void DatosSexos()
        {
            List<Sexos> list = Sexos.DatosSexos();
            {
                cbxSexoC.DataSource = list;
                cbxSexoC.ValueMember = "id_sexo";
                cbxSexoC.DisplayMember = "sexo";
            }
        }
        private void DatosEstado()
        {
            List<Estados> list = Estados.DatosEstados();
            {
                cbxEstadoC.DataSource = list;
                cbxEstadoC.ValueMember = "id_estado";
                cbxEstadoC.DisplayMember = "estado";
            }
        }
        private void DatosEstadoCivil()
        {
            List<EstadosCiviles> list = EstadosCiviles.DatosMaritalStatuses();
            {
                cbxEstadoCivilC.DataSource = list;
                cbxEstadoCivilC.ValueMember = "id_estado_civil";
                cbxEstadoCivilC.DisplayMember = "estado_civil";
            }
        }
        private void ClearTxt()
        {
            txtNamesC.Text = String.Empty;
            txtLstNamesC.Text = String.Empty;
            txtPhoneC.Text = String.Empty;
            txtCedulaC.Text = String.Empty;
            txtEmailC.Text = String.Empty;
            txtDirectionC.Text = String.Empty;

        }
        private void BuRegisterC_Click(object sender, EventArgs e)
        {
            var Mensaje = MessageBox.Show($"¿Desea registrar los datos de esta persona como cliente?", "Informe de registro",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Mensaje == DialogResult.Yes)
            {
                Clientes clientes = new Clientes();
                clientes.nombres = txtNamesC.Text;
                clientes.apellidos = txtLstNamesC.Text;
                clientes.id_sexo = Convert.ToInt32(cbxSexoC.SelectedValue);
                clientes.telefono = txtPhoneC.Text;
                clientes.cedula = txtCedulaC.Text;
                clientes.id_estado_civil = Convert.ToInt32(cbxEstadoCivilC.SelectedValue);
                clientes.email = txtEmailC.Text;
                clientes.direccion = txtDirectionC.Text;
                clientes.id_estado = Convert.ToInt32(cbxEstadoC.SelectedValue);
                Clientes.RegistrarClientes(clientes);
                MessageBox.Show($"Cliente registrado con exito!", "Registro completado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTxt();
            }

        }

        private void BuBuscarC_Click(object sender, EventArgs e)
        {
            ReportesClientes reportesClientes = new ReportesClientes();
            reportesClientes.ClienteSelecionado += (clientes) =>
            {
                txtIdC.Text = clientes.id_cliente.ToString();
                txtNamesC.Text = clientes.nombres.ToString();
                txtLstNamesC.Text = clientes.apellidos.ToString();
                cbxSexoC.SelectedValue = clientes.id_sexo;
                txtPhoneC.Text = clientes.telefono.ToString();
                txtCedulaC.Text = clientes.cedula.ToString();
                cbxEstadoCivilC.SelectedValue = clientes.id_estado_civil;
                txtEmailC.Text = clientes.email.ToString();
                txtDirectionC.Text = clientes.direccion.ToString();
                cbxEstadoC.SelectedValue = clientes.id_estado;
            };
            reportesClientes.ShowDialog();
        }

        private void BuUpdateC_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtIdC.Text))
            {
                MessageBox.Show($"Debe buscar y seleccional a un cliente para actualizar sus datos", 
                    "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var Mensaje = MessageBox.Show($"¿Desea actualizar los datos de este cliente?", "Informe de actualizacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(Mensaje == DialogResult.Yes)
                {
                    Clientes clientes = new Clientes();
                    clientes.id_cliente = Convert.ToInt32(txtIdC.Text);
                    clientes.nombres = txtNamesC.Text;
                    clientes.apellidos = txtLstNamesC.Text;
                    clientes.id_sexo = Convert.ToInt32(cbxSexoC.SelectedValue);
                    clientes.telefono = txtPhoneC.Text;
                    clientes.cedula = txtCedulaC.Text;
                    clientes.id_estado_civil = Convert.ToInt32(cbxEstadoCivilC.SelectedValue);
                    clientes.email = txtEmailC.Text;
                    clientes.direccion = txtDirectionC.Text;
                    clientes.id_estado = Convert.ToInt32(cbxEstadoC.SelectedValue);
                    Clientes.ActualizarCliente(clientes);
                    MessageBox.Show($"Datos del cliente actualizados con exito!", "Actualizacion de datos completada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTxt();
                }

            }
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {

            
        }

        private void BuDeleteC_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtIdC.Text))
            {
                MessageBox.Show($"Debe buscar y selecional a un cliente para elinimarlo",
               "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var Mensaje = MessageBox.Show($"¿Desea eliminar a este cliente del registro?", "Informe de eliminacion",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Mensaje == DialogResult.Yes)
                {
                    Clientes clientes = new Clientes();
                    clientes.id_cliente = Convert.ToInt32(txtIdC.Text);
                    Clientes.ElinimarCliente(clientes);
                    MessageBox.Show($"Cliente eliminado del registro con exito!", "Eliminacion de cliente completada",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTxt();
                }
            }
                   

        }

        private void BuExit_Click(object sender, EventArgs e) => this.Close();
       
    }
}
