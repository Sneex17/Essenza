using Essenza.Clases;
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

namespace Essenza.Forms
{
    public partial class RegistroSuplidores : Form
    {
        public RegistroSuplidores()
        {
            InitializeComponent();
            DatosCbx();
            txtIdS.Enabled = false;
        }

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
        private void ClearTxt()
        {
            txtIdS.Text = string.Empty;
            txtNamesS.Text = string.Empty;
            txtPhoneS.Text = string.Empty;
            txtEmailS.Text = string.Empty;
            txtDirectionS.Text = string.Empty;
        }
        private void BuRegisterSuplidor_Click(object sender, EventArgs e)
        {
            var mensaje = MessageBox.Show($"¿Desea registrar este suplidor?", "Registro de Suplidores", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(mensaje == DialogResult.Yes)
            {
                Suplidores suplidores = new Suplidores();
                suplidores.nombres = txtNamesS.Text;
                suplidores.telefono = txtPhoneS.Text;
                suplidores.email = txtEmailS.Text;
                suplidores.direccion = txtDirectionS.Text;
                suplidores.id_pais = Convert.ToInt32(cbxPaisesS.SelectedValue);
                suplidores.id_estado = Convert.ToInt32(cbxEstadoS.SelectedValue);
                Suplidores.AgregarSuplidor(suplidores);
                MessageBox.Show($"Suplidor registrado con exito!", "Registro de Suplidores",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTxt();
            }
        }

        private void BuUpdateSuplidor_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtIdS.Text))
            {
                MessageBox.Show($"Debe de buscar y selecional a un suplidor para actualizar sus datos", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var mensaje = MessageBox.Show($"¿Desea actualizar los datos de este suplidor?", "Actualizacion de datos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje == DialogResult.Yes)
                {
                    Suplidores suplidores = new Suplidores();
                    suplidores.id_suplidor = Convert.ToInt32(txtIdS.Text);
                    suplidores.nombres = txtNamesS.Text;
                    suplidores.telefono = txtPhoneS.Text;
                    suplidores.email = txtEmailS.Text;
                    suplidores.direccion = txtDirectionS.Text;
                    suplidores.id_pais = Convert.ToInt32(cbxPaisesS.SelectedValue);
                    suplidores.id_estado = Convert.ToInt32(cbxEstadoS.SelectedValue);
                    Suplidores.ActualizarSuplidor(suplidores);
                    MessageBox.Show($"Datos del suplidor actualizados con exito!", "Actualizacion completa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTxt();
                }
            }
        }

        private void BuBuscarSuplidor_Click(object sender, EventArgs e)
        {
            ReportesSuplidores reportesSuplidores = new ReportesSuplidores();

            reportesSuplidores.SelecionalSuplidor += (suplidores) =>
            {
                txtIdS.Text = suplidores.id_suplidor.ToString();
                txtNamesS.Text = suplidores.nombres;
                txtPhoneS.Text = suplidores.telefono;
                txtEmailS.Text = suplidores.email;
                txtDirectionS.Text = suplidores.direccion;
                cbxPaisesS.SelectedValue = suplidores.id_pais;
                cbxEstadoS.SelectedValue = suplidores.id_estado;
            };
            reportesSuplidores.ShowDialog();
        }

        private void BuDeleteSuplidor_Click(object sender, EventArgs e)
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
    }
}
