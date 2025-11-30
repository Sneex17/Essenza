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
using Essenza.Forms;

namespace Essenza.ViewsAdmin
{
    public partial class ControlUsuarios : Form
    {
        Usuarios user = new Usuarios();
        public ControlUsuarios(int? idUser)
        {
            InitializeComponent();
            txtBox();
            DatosCBX();
            iduser(idUser);
            DatosUser();
            ctrlBotones();



        }
        private void iduser(int? id)
        {
            if(id != null )
                user.id_usuario = Convert.ToInt32(id);
        }
        private void txtBox()
        {
            txtIdUser.Enabled = false;
            txtIdEmp.Enabled = false;
        }

        private void ctrlBotones()
        {
            if(!(String.IsNullOrWhiteSpace(txtIdUser.Text)))
            {
                BuBuscarE.Visible = false;
            }
        }
        private void DatosCBX()
        {
            List<Roles> listR = Roles.listaRoles();
            {
                cbxRolUser.DataSource = listR;
                cbxRolUser.ValueMember = "id_rol";
                cbxRolUser.DisplayMember = "rol";
                
            }

            List<Estados> listE = Estados.DatosEstados();
            {
                cbxEstadoUser.DataSource = listE;
                cbxEstadoUser.ValueMember = "id_estado";
                cbxEstadoUser.DisplayMember = "estado";
            }

        }

        private void BuBuscarE_Click(object sender, EventArgs e)
        {
            EmployeeReports reporteE = new EmployeeReports();

            reporteE.EmpleadoSelecionado += (empleados) =>
            {
                txtIdEmp.Text = Convert.ToString(empleados.id_empleado);
            };
            reporteE.ShowDialog();   
        }

        private void DatosUser()
        {
            int id = user.id_usuario;

            List<Usuarios> listUser = Usuarios.ListaUsuarios();
            var datos = from u in listUser where u.id_usuario == id select u;

            foreach (var u in datos)
            {
                txtIdUser.Text = u.id_usuario.ToString();
                txtIdEmp.Text = u.id_empleado.ToString();
                txtUser.Text = u.usuario.ToString();
                txtPass.Text = u.pass.ToString();
                cbxRolUser.SelectedValue = u.id_rol;
                cbxEstadoUser.SelectedValue = u.id_estado;
            }
        }
        private void BuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtIdUser.Text))
                {
                    var Mensaje = MessageBox.Show($"¿Desea crearle un usuario a este empleado?", "Creacion de usuario",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Mensaje == DialogResult.Yes)
                    {
                        Usuarios usuario = new Usuarios();
                        usuario.id_empleado = Convert.ToInt32(txtIdEmp.Text);
                        usuario.usuario = txtUser.Text;
                        usuario.pass = txtPass.Text;
                        usuario.id_rol = Convert.ToInt32(cbxRolUser.SelectedValue.ToString());
                        usuario.id_estado = Convert.ToInt32(cbxEstadoUser.SelectedValue.ToString());
                        usuario.fecha_creacion = DateTime.Today;
                        usuario.ultimo_acceso = Convert.ToDateTime("1905-07-01 00:00:00.000");
                        Usuarios.AgregarUsuarios(usuario);

                        MessageBox.Show($"Usuario creado con exito!", "Creacion de usuario",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                else
                {
                    var Mensaje = MessageBox.Show($"¿Desea actualizar los datos de este usuario?", "Actualizacion de usuario",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Mensaje == DialogResult.Yes)
                    {
                        Usuarios usuario = new Usuarios();
                        usuario.id_usuario = Convert.ToInt32(txtIdUser.Text);
                        usuario.id_empleado = Convert.ToInt32(txtIdEmp.Text);
                        usuario.usuario = txtUser.Text;
                        usuario.pass = txtPass.Text;
                        usuario.id_rol = Convert.ToInt32(cbxRolUser.SelectedValue.ToString());
                        usuario.id_estado = Convert.ToInt32(cbxEstadoUser.SelectedValue.ToString());
                        
                        Usuarios.UpdateUsuarios(usuario);

                        MessageBox.Show($"Datos del usuario actualizados con exito!", "Actualizacion de usuario",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {

                
            }
        }
    }
}
