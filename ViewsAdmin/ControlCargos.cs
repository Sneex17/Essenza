using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Presentation;
using Essenza.Clases;

namespace Essenza.ViewsAdmin
{
    public partial class ControlCargos : Form
    {
        CargosEmpleados cargos = new CargosEmpleados();
        public ControlCargos(int? idCargo)
        {
            InitializeComponent();
            controlTxt();
            idcargo(idCargo);
            datosCargos();
        }

        private void controlTxt()
        {
            txtIdCargo.Enabled = false;
        }
        private void idcargo(int? id)
        {
            if(id != null)
                cargos.id_cargo = Convert.ToInt32(id);
        }

        private void datosCargos()
        {
            int id = cargos.id_cargo;

            List<CargosEmpleados> listCargos = CargosEmpleados.DatosCargos();

            var datos = from u in listCargos where u.id_cargo == id select u;
            foreach (var u in datos)
            {
                txtIdCargo.Text = u.id_cargo.ToString();
                txtCargo.Text = u.cargo.ToString();
                txtSalario.Text = u.salario.ToString();
            }
        }

        private void BuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtIdCargo.Text))
                {
                    
                    var Mensaje = MessageBox.Show($"¿Desea agregar este cargo de empleado?", "Registro de Cargos",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Mensaje == DialogResult.Yes)
                    {
                        CargosEmpleados cargos = new CargosEmpleados();
                        cargos.cargo = txtCargo.Text;
                        cargos.salario = Convert.ToDecimal(txtSalario.Text);
                        CargosEmpleados.AgregarCargos(cargos);

                        MessageBox.Show($"Cargo de empleado agregado con exito!", "Registro de Cargos",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    var Mensaje = MessageBox.Show($"¿Desea actualizar los datos este cargo de empleado?", "Registro de Cargos",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Mensaje == DialogResult.Yes)
                    {
                        CargosEmpleados cargos = new CargosEmpleados();
                        cargos.id_cargo = Convert.ToInt32(txtIdCargo.Text);
                        cargos.cargo = txtCargo.Text;
                        cargos.salario = Convert.ToDecimal(txtSalario.Text);
                        CargosEmpleados.ActualizarCargos(cargos);

                        MessageBox.Show($"Datos del cargo de empleado actualizados con exito!", "Registro de Cargos",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex) 
            {

            }
                    
            
        }
    }
}
