using Essenza.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essenza.Forms
{
    public partial class RegistrationEmployee : Form
    {
        public RegistrationEmployee()
        {
            InitializeComponent();
            txtIdE.Enabled = false;
            txtSalaryE.Enabled = false;
            DatosTotal();
        }
        private void DatosTotal()
        {
            DatosSexs();
            DatosMaritalStatus();
            DatosEmployeeStatus();
            DatosCargosEmpleados();
        }
        private void ClearTextBox()
        {
            txtIdE.Clear();
            txtNamesE.Clear();
            txtLstNamesE.Clear();
            txtPhoneE.Clear();
            txtDirectionE.Clear();
            txtEmailE.Clear();
            txtSalaryE.Clear();
        }
        private void DatosSexs()
        {
            List<Sexos> list = Sexos.DatosSexos();
            {
                cbxSexE.DataSource = list;
                cbxSexE.ValueMember = "id_sexo";
                cbxSexE.DisplayMember = "sexo";
            }
        }
        private void DatosMaritalStatus()
        {
            List<EstadosCiviles> list = EstadosCiviles.DatosMaritalStatuses();
            {
                cbxMaritalStatusE.DataSource = list;
                cbxMaritalStatusE.ValueMember = "id_estado_civil";
                cbxMaritalStatusE.DisplayMember = "estado_civil";
            }
        }
        private void DatosEmployeeStatus()
        {
            List<Estados> list = Estados.DatosEstados();
            {
                cbxEmployeeStatuses.DataSource = list;
                cbxEmployeeStatuses.ValueMember = "id_estado";
                cbxEmployeeStatuses.DisplayMember = "estado";
            }
        }
        private void DatosCargosEmpleados()
        {
            List<CargosEmpleados> list = CargosEmpleados.DatosCargos();
            {
                cbxCargoEmp.DataSource = list;
                cbxCargoEmp.ValueMember = "id_cargo";
                cbxCargoEmp.DisplayMember = "cargo";
            }
        }

        private void BuDeleteE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdE.Text))
            {
                MessageBox.Show($"Debe buscar y selecional un empleado para elinimarlo",
               "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var Mensaje = MessageBox.Show($"¿Desea eliminar a este empleado del registro?", "Informe de eliminacion",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(Mensaje == DialogResult.Yes)
                {
                    Empleados employees = new Empleados();
                    employees.id_empleado = Convert.ToInt32(txtIdE.Text);
                    Empleados.DeleteEmployee(employees);
                    MessageBox.Show($"Empleado eliminado!",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox();
                }
                
            }
        }

        private void BuRegister_Click(object sender, EventArgs e)
        {
            var Mensaje = MessageBox.Show($"¿Desea registrar los datos de esta persona como empleado?", "Informe de registro",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Mensaje == DialogResult.Yes)
            {
                Empleados employees = new Empleados();
                employees.nombres = txtNamesE.Text;
                employees.apellidos = txtLstNamesE.Text;
                employees.id_sexo = Convert.ToInt32(cbxSexE.SelectedValue.ToString());
                employees.telefono = txtPhoneE.Text;
                employees.fecha_nacimiento = dateBirthE.Value;
                employees.edad = Convert.ToInt32(Empleados.AgeEmployee(employees));
                employees.direccion = txtDirectionE.Text;
                employees.id_estado_civil = Convert.ToInt32(cbxMaritalStatusE.SelectedValue.ToString());
                employees.email = txtEmailE.Text;
                employees.fecha_contrato = dateContractE.Value;
                employees.id_cargo = Convert.ToInt32(cbxCargoEmp.SelectedValue.ToString());
                employees.salario = Convert.ToDecimal(txtSalaryE.Text);
                employees.id_estado = Convert.ToInt32(cbxEmployeeStatuses.SelectedValue.ToString());
                Empleados.AddEmployee(employees);
                MessageBox.Show($"Empleado registrado!",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
            }

        }

        private void BuUpdate_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtIdE.Text))
            {
                MessageBox.Show($"Debe buscar y selecional un empleado para actualizar sus datos",
               "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var Mensaje = MessageBox.Show($"¿Desea actualizar los datos de este empleado?", "Informe de actualizacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(Mensaje == DialogResult.Yes)
                {
                    Empleados employees = new Empleados();
                    employees.id_empleado = Convert.ToInt32(txtIdE.Text);
                    employees.nombres = txtNamesE.Text;
                    employees.apellidos = txtLstNamesE.Text;
                    employees.id_sexo = Convert.ToInt32(cbxSexE.SelectedValue.ToString());
                    employees.telefono = txtPhoneE.Text;
                    employees.fecha_nacimiento = dateBirthE.Value;
                    employees.edad = Convert.ToInt32(Empleados.AgeEmployee(employees));
                    employees.direccion = txtDirectionE.Text;
                    employees.id_estado_civil = Convert.ToInt32(cbxMaritalStatusE.SelectedValue.ToString());
                    employees.email = txtEmailE.Text;
                    employees.fecha_contrato = dateContractE.Value;
                    employees.id_cargo = Convert.ToInt32(cbxCargoEmp.SelectedValue.ToString());
                    employees.salario = Convert.ToDecimal(txtSalaryE.Text);
                    employees.id_estado = Convert.ToInt32(cbxEmployeeStatuses.SelectedValue.ToString());
                    Empleados.UpdateEmployee(employees);
                    MessageBox.Show($"Datos del empleado actualizados!",
                   "Information de actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox();
                }
                
            }
        }

        private void cbxCargoEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conexion = EssenzaSystemDB.EssenzaDB())
            {
                string Newquery = @"SELECT salario FROM cargos WHERE cargo = @cargo";
                SqlCommand comando = new SqlCommand(Newquery, conexion);
                comando.Parameters.AddWithValue("@cargo", cbxCargoEmp.Text);
                using (SqlDataReader leer = comando.ExecuteReader())
                {
                    if (leer.Read())
                    {
                        txtSalaryE.Text = leer["salario"].ToString();
                    }
                    else
                    {
                        txtSalaryE.Text = "";
                    }
                }

            }
        }

        private void BuBuscarE_Click(object sender, EventArgs e)
        {
            EmployeeReports EmployeesReports = new EmployeeReports();
            
            EmployeesReports.EmpleadoSelecionado += (employees) =>
            {
                txtIdE.Text = employees.id_empleado.ToString();
                txtNamesE.Text = employees.nombres;
                txtLstNamesE.Text = employees.apellidos;
                cbxSexE.SelectedValue = employees.id_sexo;
                dateBirthE.Value = employees.fecha_nacimiento;
                txtPhoneE.Text = employees.telefono;
                txtDirectionE.Text = employees.direccion;
                cbxMaritalStatusE.SelectedValue = employees.id_estado_civil;
                txtEmailE.Text = employees.email;
                dateContractE.Value = employees.fecha_contrato;
                cbxCargoEmp.SelectedValue = employees.id_cargo;
                txtSalaryE.Text = employees.salario.ToString();
                cbxEmployeeStatuses.SelectedValue = employees.id_estado;

            };
            EmployeesReports.ShowDialog();
        }

        private void txtNamesE_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == Convert.ToChar(Keys.Enter)) txtLstNamesE.Focus(); }

        private void txtLstNamesE_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == Convert.ToChar(Keys.Enter)) txtPhoneE.Focus(); }
        private void txtPhoneE_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == Convert.ToChar(Keys.Enter)) txtDirectionE.Focus(); }

        private void txtDirectionE_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == Convert.ToChar(Keys.Enter)) txtEmailE.Focus(); }

        private void txtEmailE_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == Convert.ToChar(Keys.Enter)) txtNamesE.Focus(); }

        private void BuExit_Click(object sender, EventArgs e) => this.Close();

    }
}
