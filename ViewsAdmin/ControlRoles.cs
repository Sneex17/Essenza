using Essenza.Clases;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essenza.ViewsAdmin
{
    public partial class ControlRoles : Form
    {
        Roles rol = new Roles();
        public ControlRoles(int? idRol)
        {
            InitializeComponent();
            txtIdRol.Enabled = false;
            idrol(idRol);
            DatosRol();
        }

        private void idrol(int? id)
        {
            if(id != null)
                rol.id_rol = Convert.ToInt32(id);  
        }

        private void DatosRol()
        {
            int id = rol.id_rol;

            List<Roles> listRol = Roles.listaRoles();
            var datos = from u in listRol where u.id_rol == id select u;

            foreach (var u in datos)
            {
                txtIdRol.Text = u.id_rol.ToString();
                txtRol.Text = u.rol.ToString();  
            }
        }
        private void BuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrWhiteSpace(txtIdRol.Text))
                {
                    var Mensaje = MessageBox.Show($"¿Desea agregar este rol de usuario?", "Registro de Roles",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Mensaje == DialogResult.Yes)
                    {
                        Roles roles = new Roles();
                        roles.rol = txtRol.Text;
                        Roles.AgregarRol(roles);

                        MessageBox.Show($"Rol registrado con exito!", "Registro de Roles",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    var Mensaje = MessageBox.Show($"¿Actualizar los datos de este rol?", "Actualizacion de Roles",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Mensaje == DialogResult.Yes)
                    {
                        Roles roles = new Roles();
                        roles.id_rol = Convert.ToInt32(txtIdRol.Text);
                        roles.rol = txtRol.Text;
                        Roles.ActualizarRol(roles);

                        MessageBox.Show($"Rol actualizado con exito!", "Actualizacion de Roles",
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
