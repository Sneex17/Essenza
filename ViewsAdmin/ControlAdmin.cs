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

namespace Essenza.ViewsAdmin
{
    public partial class ControlAdmin : Form
    {
        int? idUser, idRol, idCargo, idCategoria;
        //public event Action<Usuarios> MoverDatosUser;
        public ControlAdmin()
        {
            InitializeComponent();
            SeleccionDGV();
            DatosDGV();
            
        }

        private void SeleccionDGV()
        {
            dataUsuarios.ClearSelection();
            dataRoles.ClearSelection();
            dataCargos.ClearSelection();
            dataCategorias.ClearSelection();
            
        }

        private void DatosDGV()
        {
            dataUsuarios.Rows.Clear();
            foreach (var list in Usuarios.ListaUsuarios())
            {
                object[] array = {list.id_usuario, list.id_empleado, list.usuario, list.pass, 
                    list.id_rol, list.id_estado, list.fecha_creacion, list.ultimo_acceso };

                dataUsuarios.Rows.Add(array);
            }

            dataCargos.DataSource = CargosEmpleados.DatosCargos();
            dataCategorias.DataSource = Categorias.listaCategorias();
            dataRoles.DataSource = Roles.listaRoles();
            
        }

        private void BuRegister_Click(object sender, EventArgs e)
        {
            if(rbUsuarios.Checked)
            {
                ControlUsuarios clUsuarios = new ControlUsuarios(idUser);
                clUsuarios.ShowDialog();

            }
            else if (rbCargos.Checked)
            {
                
            }
            else if (rbRoles.Checked)
            {
                ControlRoles clRoles = new ControlRoles(idRol);
                clRoles.ShowDialog();
            }
            else if (rbCategorias.Checked)
            {

            }
            else
            {
                MessageBox.Show($"Debe marcar el tipo de registro que desea registrar", "informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void BuUpdate_Click(object sender, EventArgs e)
        {
            if (rbUsuarios.Checked)
            {
                ControlUsuarios clUsuarios = new ControlUsuarios(idUser);
                clUsuarios.ShowDialog();

            }
            else if (rbCargos.Checked)
            {

            }
            else if (rbRoles.Checked)
            {
                ControlRoles clRoles = new ControlRoles(idRol);
                clRoles.ShowDialog();
            }
            else if (rbCategorias.Checked)
            {

            }
            else
            {
                MessageBox.Show($"Debe marcar el tipo de registro que desea actualizar", "informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void BuDeleteE_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbUsuarios.Checked)
                {
                    var Mensaje = MessageBox.Show($"¿Desea eliminar este usuario?", "Eliminar usuario",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(Mensaje == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataUsuarios.CurrentRow.Cells["id_usuario"].Value);
                        Usuarios.EliminarUser(id);
                        MessageBox.Show($"usuario eliminado con exito!", "Eliminar cargo",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
                        DatosDGV();
                    }
                    
                }
                else if (rbCargos.Checked)
                {
                    var Mensaje = MessageBox.Show($"¿Desea eliminar este cargo?", "Eliminar cargo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Mensaje == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataCargos.CurrentRow.Cells["id_cargo"].Value);
                        MessageBox.Show($"cargo eliminado con exito!", "Eliminar cargo",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
                        DatosDGV();
                    }
                    
                }
                else if (rbRoles.Checked)
                {
                    var Mensaje = MessageBox.Show($"¿Desea eliminar este rol?", "Eliminar rol",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Mensaje == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataRoles.CurrentRow.Cells["id_rol"].Value);
                        Roles.EliminarRol(id);
                        MessageBox.Show($"Rol eliminado con exito!", "Eliminar rol",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
                        DatosDGV();
                    }

                    
                }
                else if (rbCategorias.Checked)
                {
                    var Mensaje = MessageBox.Show($"¿Desea eliminar esta categoria?", "Eliminar categoria",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Mensaje == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataCategorias.CurrentRow.Cells["id_categoria"].Value);

                        MessageBox.Show($"Categoria eliminada con exito!", "Eliminar categoria",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
                        DatosDGV();
                    } 
                }
                else
                {
                    MessageBox.Show($"Debe marcar el tipo de registro que desea eliminar", "informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception ex) 
            {

            }
            
        }

        private void dataUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //idUser = Convert.ToInt32(dataUsuarios.CurrentRow.Cells["id_usuario"].Value);
        }

        private void dataUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            BuRegister.Visible = false;
            BuUpdate.Visible = true;
            BuDeleteE.Visible = true;
            BuNuevo.Visible = true;
            idUser = Convert.ToInt32(dataUsuarios.CurrentRow.Cells["id_usuario"].Value);
        }
        private void dataRoles_SelectionChanged(object sender, EventArgs e)
        {
            BuRegister.Visible = false;
            BuUpdate.Visible = true;
            BuDeleteE.Visible = true;
            BuNuevo.Visible = true;
            idRol = Convert.ToInt32(dataRoles.CurrentRow.Cells["id_rol"].Value);
        }


        private void BuNuevo_Click(object sender, EventArgs e)
        {
            SeleccionDGV();
            BuRegister.Visible = true;
            BuUpdate.Visible = false;
            BuDeleteE.Visible = false;
            BuNuevo.Visible = false;
            idUser = null;
            idRol = null;
            idCargo = null;
            idCategoria = null;

        }

        //Salir de la ventana
        private void BuExit_Click(object sender, EventArgs e) => this.Close();

        

        
    }
}
