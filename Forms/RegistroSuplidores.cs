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
    }
}
