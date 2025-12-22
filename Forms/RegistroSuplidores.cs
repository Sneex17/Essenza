using Essenza.Clases;
using Essenza.ClasesAR;
using Essenza.FormsReportes;
using OpenXmlPowerTools;
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
    public partial class RegistroSuplidores : Form
    {
        public RegistroSuplidores()
        {
            InitializeComponent();
            DatosCbx();
            txtIdS.Enabled = false;
            CtrlSuplidores();
            //CheckBoxSuplidores();
        }

        //Limpiar los textbox
        private void ClearTxt()
        {
            txtIdS.Text = string.Empty;
            txtNamesS.Text = string.Empty;
            txtPhoneS.Text = string.Empty;
            txtEmailS.Text = string.Empty;
            txtDirectionS.Text = string.Empty;
            txtRNC.Text = string.Empty;
        }

        //Control de los tipos de suplidores
        private void CtrlSuplidores()
        {
            lbPais.Visible = false;
            cbxPaisesS.Visible = false;
            lbRNC.Visible = false;
            txtRNC.Visible = false;
        }

        //Ctrl de los ChecBox
        private void rbNacional_CheckedChanged(object sender, EventArgs e)
        {
            lbRNC.Visible = true;
            txtRNC.Visible = true;


            lbPais.Visible = false;
            cbxPaisesS.Visible = false;

        }
        private void rbInternacional_CheckedChanged(object sender, EventArgs e)
        {
            lbPais.Visible = true;
            cbxPaisesS.Visible = true;

            lbRNC.Visible = false;
            txtRNC.Visible = false;
        }
        
        
        //Llenar los combobox con datos
        private void DatosCbx()
        {
            DatosEstados();
            DatosPaises();
        }
        private void DatosEstados()
        {
            List<Estados> list = Estados.DatosEstados();
            {
                cbxEstadoS.DataSource = list;
                cbxEstadoS.ValueMember = "id_estado";
                cbxEstadoS.DisplayMember = "estado";               
            }
        }
        private void DatosPaises()
        {
            List<Paises> list = Paises.DatosPaises();
            {
                cbxPaisesS.DataSource = list;
                cbxPaisesS.ValueMember = "id_pais";
                cbxPaisesS.DisplayMember = "pais";         
            }
        }

        //Metodo de Excepciones
        private void Excepciones()
        {
            bool tx1, tx2, tx3, tx4, tx5;
            tx1 = String.IsNullOrWhiteSpace(txtNamesS.Text);
            tx2 = String.IsNullOrWhiteSpace(txtPhoneS.Text);
            tx3 = String.IsNullOrWhiteSpace(txtEmailS.Text);
            tx4 = String.IsNullOrWhiteSpace(txtDirectionS.Text);
            tx5 = String.IsNullOrWhiteSpace(txtRNC.Text);
            if (tx1 || tx2 || tx3 || tx4 || tx5)
            {
                if (tx1) throw new ExcepcionesPersonalizadas("El campo de Nombre esta vacio");
                if (tx2) throw new ExcepcionesPersonalizadas("El campo de Telefono esta vacio");
                if (tx3) throw new ExcepcionesPersonalizadas("El campo de Email esta vacio");
                if (tx4) throw new ExcepcionesPersonalizadas("El campo de Direccion esta vacio");
                if (tx5) throw new ExcepcionesPersonalizadas("El campo de RNC esta vacio");
            }
            if (!txtNamesS.Text.All(c => char.IsLetter(c) || c == ' '))
                throw new ExcepcionesPersonalizadas("El campo de Nombre tiene caracteres no validos\nInserte solo Letras.");
            if (txtPhoneS.Text.All(char.IsLetter))
                throw new ExcepcionesPersonalizadas("El campo de Telefono tiene caracteres no validos\nInserte un Telefono valido (000) 000-0000.");
            if (txtRNC.Text.All(char.IsLetter))
                throw new ExcepcionesPersonalizadas("El campo de RNC tiene caracteres no validos\nInserte un RNC valido 001-0000001-1.");
        }
        //Boton de registrar
        private void BuRegisterSuplidor_Click(object sender, EventArgs e)
        {  
            try
            {
                if(String.IsNullOrWhiteSpace(txtIdS.Text))
                {
                    if(String.IsNullOrWhiteSpace(txtRNC.Text))
                    {
                        txtRNC.Text = "0";
                    }
                    Excepciones();

                    var mensaje = MessageBox.Show($"¿Desea registrar este suplidor?", "Registro de Suplidores",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        if(rbNacional.Checked)
                        {
                            Suplidores suplidores = new Suplidores();
                            suplidores.nombres = txtNamesS.Text;
                            suplidores.telefono = txtPhoneS.Text;
                            suplidores.email = txtEmailS.Text;
                            suplidores.direccion = txtDirectionS.Text;
                            suplidores.id_pais = 7;
                            suplidores.id_estado = Convert.ToInt32(cbxEstadoS.SelectedValue);
                            suplidores.RNC = txtRNC.Text;
                            Suplidores.AgregarSuplidor(suplidores);
                            MessageBox.Show($"Suplidor registrado con exito!", "Registro de Suplidores",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTxt();
                        }
                        if(rbInternacional.Checked)
                        {
                            Suplidores suplidores = new Suplidores();
                            suplidores.nombres = txtNamesS.Text;
                            suplidores.telefono = txtPhoneS.Text;
                            suplidores.email = txtEmailS.Text;
                            suplidores.direccion = txtDirectionS.Text;
                            suplidores.id_pais = Convert.ToInt32(cbxPaisesS.SelectedValue);
                            suplidores.id_estado = Convert.ToInt32(cbxEstadoS.SelectedValue);
                            suplidores.RNC = txtRNC.Text;
                            Suplidores.AgregarSuplidor(suplidores);
                            MessageBox.Show($"Suplidor registrado con exito!", "Registro de Suplidores",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTxt();
                        }

                        
                    }
                }
                else
                {
                    throw new Exception(ExcepcionesPersonalizadas.RegistroInValido());
                }
                
            }
            catch (ExcepcionesPersonalizadas exp)
            {
                MessageBox.Show($"{exp.Message}", "Campo requerido vacio", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Informacio",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        

        //Boton de actualizar
        private void BuUpdateSuplidor_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtIdS.Text))
                {
                    MessageBox.Show($"Debe de buscar y selecional a un suplidor para actualizar sus datos", "Informacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Excepciones();

                    var mensaje = MessageBox.Show($"¿Desea actualizar los datos de este suplidor?", "Actualizacion de datos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {

                        if(rbNacional.Checked)
                        {
                            Suplidores suplidores = new Suplidores();
                            suplidores.id_suplidor = Convert.ToInt32(txtIdS.Text);
                            suplidores.nombres = txtNamesS.Text;
                            suplidores.telefono = txtPhoneS.Text;
                            suplidores.email = txtEmailS.Text;
                            suplidores.direccion = txtDirectionS.Text;
                            suplidores.id_pais = 7;
                            suplidores.id_estado = Convert.ToInt32(cbxEstadoS.SelectedValue);
                            suplidores.RNC = txtRNC.Text;
                            Suplidores.ActualizarSuplidor(suplidores);
                            MessageBox.Show($"Datos del suplidor actualizados con exito!", "Actualizacion completa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTxt();
                        }
                        if(rbInternacional.Checked)
                        {
                            Suplidores suplidores = new Suplidores();
                            suplidores.id_suplidor = Convert.ToInt32(txtIdS.Text);
                            suplidores.nombres = txtNamesS.Text;
                            suplidores.telefono = txtPhoneS.Text;
                            suplidores.email = txtEmailS.Text;
                            suplidores.direccion = txtDirectionS.Text;
                            suplidores.id_pais = Convert.ToInt32(cbxPaisesS.SelectedValue);
                            suplidores.id_estado = Convert.ToInt32(cbxEstadoS.SelectedValue);
                            suplidores.RNC = "0";
                            Suplidores.ActualizarSuplidor(suplidores);
                            MessageBox.Show($"Suplidor registrado con exito!", "Registro de Suplidores",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTxt();
                        }
                        
                    }
                }
            }
            catch (ExcepcionesPersonalizadas exp)
            {
                MessageBox.Show($"{exp.Message}", "Campo requerido vacio",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Informacio",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }           
        }

        //Boton de eliminar
        private void BuDeleteSuplidor_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtIdS.Text))
                {
                    MessageBox.Show($"Debe de buscar y selecional a un suplidor para eliminarlo", "Informacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var mensaje = MessageBox.Show($"¿Desea eliminar a este suplidor?", "Eliminacion de suplidor",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        Suplidores suplidores = new Suplidores();
                        suplidores.id_suplidor = Convert.ToInt32(txtIdS.Text);
                        Suplidores.EliminarSuplidor(suplidores);
                        MessageBox.Show($"Suplidor eliminado con exito!", "Eliminacion de suplidor",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTxt();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Informacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //Evento para Buscar los datos de algun registro
        private void BuBuscarSuplidor_Click(object sender, EventArgs e)
        {
            ReportesSuplidores reportesSuplidores = new ReportesSuplidores();

            reportesSuplidores.SelecionalSuplidor += (suplidores) =>
            {
                if(suplidores.RNC.Length > 1)
                {
                    lbRNC.Visible = true;
                    txtRNC.Visible = true;
                    rbNacional.Checked = true;

                    txtIdS.Text = suplidores.id_suplidor.ToString();
                    txtNamesS.Text = suplidores.nombres;
                    txtPhoneS.Text = suplidores.telefono;
                    txtEmailS.Text = suplidores.email;
                    txtDirectionS.Text = suplidores.direccion;
                    cbxPaisesS.SelectedValue = suplidores.id_pais;
                    cbxEstadoS.SelectedValue = suplidores.id_estado;
                    txtRNC.Text = suplidores.RNC;
                }
                else
                {
                    lbPais.Visible = true;
                    cbxPaisesS.Visible = true;
                    rbInternacional.Checked = true;

                    txtIdS.Text = suplidores.id_suplidor.ToString();
                    txtNamesS.Text = suplidores.nombres;
                    txtPhoneS.Text = suplidores.telefono;
                    txtEmailS.Text = suplidores.email;
                    txtDirectionS.Text = suplidores.direccion;
                    cbxPaisesS.SelectedValue = suplidores.id_pais;
                    cbxEstadoS.SelectedValue = suplidores.id_estado;
                    txtRNC.Text = suplidores.RNC;
                }
                
            };
            reportesSuplidores.ShowDialog();
        }

       
        //Salir de la ventana
        private void BuExit_Click(object sender, EventArgs e) => this.Close();

        
    }
}
