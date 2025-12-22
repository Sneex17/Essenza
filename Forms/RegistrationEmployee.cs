using DocumentFormat.OpenXml.Drawing;
using Essenza.Clases;
using Essenza.ClasesAR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Automation.Language;
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
            txtEmailE.Enabled = false;
            DatosTotal();
        }

        //Limpiar los textbox
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

        //Llenar los combobox con datos
        private void DatosTotal() 
        {
            DatosSexs();
            DatosMaritalStatus();
            DatosEmployeeStatus();
            DatosCargosEmpleados();
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

        //Metodo para obtener el salario
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

        //Metodo de Excepciones
        private void Excepciones()
        {
            bool txN, txA, txT, txD;

            txN = String.IsNullOrWhiteSpace(txtNamesE.Text);
            txA = String.IsNullOrWhiteSpace(txtLstNamesE.Text);
            txT = String.IsNullOrWhiteSpace(txtPhoneE.Text);
            txD = String.IsNullOrWhiteSpace(txtDirectionE.Text);

            if(txN || txA || txT || txD)
            {
                if (txN) throw new ExcepcionesPersonalizadas("El campo de Nombre esta vacio");
                if (txA) throw new ExcepcionesPersonalizadas("El campo de Apellido esta vacio");
                if (txT) throw new ExcepcionesPersonalizadas("El campo de Telefono esta vacio");
                if (txD) throw new ExcepcionesPersonalizadas("El campo de Direccion esta vacio");
            }
            
            if(!txtNamesE.Text.All(c => char.IsLetter(c) || c == ' ')) 
                throw new ExcepcionesPersonalizadas("El campo de Nombre tiene caracteres no validos\nInserte solo letras.");
            if (!txtLstNamesE.Text.All(c => char.IsLetter(c) || c == ' '))
                throw new ExcepcionesPersonalizadas("El campo de Apellido tiene caracteres no validos\nInserte solo letras.");
            if (txtPhoneE.Text.All(char.IsLetter))
                throw new ExcepcionesPersonalizadas("El campo de Telefono tiene caracteres no validos\nInserte un Telefono valido (000) 000-0000.");
        }
        //Boton de registrar
        private void BuRegister_Click(object sender, EventArgs e)
        {   
            try
            {
                Excepciones();

                Empleados employees = new Empleados();
                employees.fecha_nacimiento = dateBirthE.Value;
                employees.edad = Convert.ToInt32(Empleados.AgeEmployee(employees));
                
                if (employees.edad >= 18 && employees.edad < 65)
                {
                    var Mensaje = MessageBox.Show($"¿Desea registrar los datos de esta persona como empleado?", "Informe de registro",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Mensaje == DialogResult.Yes)
                    {
                        employees.nombres = txtNamesE.Text;
                        employees.apellidos = txtLstNamesE.Text;
                        employees.id_sexo = Convert.ToInt32(cbxSexE.SelectedValue.ToString());
                        employees.telefono = txtPhoneE.Text;
                        employees.direccion = txtDirectionE.Text;
                        employees.id_estado_civil = Convert.ToInt32(cbxMaritalStatusE.SelectedValue.ToString());
                        employees.email = "Generando Email";
                        employees.fecha_contrato = dateContractE.Value;
                        employees.id_cargo = Convert.ToInt32(cbxCargoEmp.SelectedValue.ToString());
                        employees.salario = Convert.ToDecimal(txtSalaryE.Text);
                        employees.id_estado = Convert.ToInt32(cbxEmployeeStatuses.SelectedValue.ToString());
                        Empleados.AddEmployee(employees);
                        Empleados.GeneralEmail(employees);

                        MessageBox.Show($"Empleado registrado!",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBox();
                    }
                }
                else
                {
                    MessageBox.Show($"La edad debe ser mayor o igual a 18 y menor a 65\nFavor de Modificar la Fecha de Nacimiento",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            catch (ExcepcionesPersonalizadas exp)
            {
                MessageBox.Show($"{exp.Message}",
                        "Campo requerido vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton de actualizar
        private void BuUpdate_Click(object sender, EventArgs e)
        {  
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdE.Text))
                {
                    MessageBox.Show($"Debe buscar y selecional un empleado para actualizar sus datos",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Excepciones();

                    var Mensaje = MessageBox.Show($"¿Desea actualizar los datos de este empleado?", "Informe de actualizacion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Mensaje == DialogResult.Yes)
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
            catch (ExcepcionesPersonalizadas exp)
            {
                MessageBox.Show($"{exp.Message}",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Boton de eliminar
        private void BuDeleteE_Click(object sender, EventArgs e)
        {
            try
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

                    if (Mensaje == DialogResult.Yes)
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
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Evento para Buscar los datos de algun registro
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

        //Metodos para moverse entre textbox
        private void txtNamesE_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == Convert.ToChar(Keys.Enter)) txtLstNamesE.Focus(); }
        private void txtLstNamesE_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == Convert.ToChar(Keys.Enter)) txtPhoneE.Focus(); }
        private void txtPhoneE_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == Convert.ToChar(Keys.Enter)) txtDirectionE.Focus(); }
        private void txtDirectionE_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == Convert.ToChar(Keys.Enter)) txtEmailE.Focus(); }
        private void txtEmailE_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == Convert.ToChar(Keys.Enter)) txtNamesE.Focus(); }

        //Salir de la ventana
        private void BuExit_Click(object sender, EventArgs e) => this.Close();

    }
}
