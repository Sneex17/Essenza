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
        //variables de tipo entero
        int? idUser, idRol, idCargo, idCategoria;
        //public event Action<Usuarios> MoverDatosUser;
        public ControlAdmin()
        {
            InitializeComponent();
            Inicio();
            SeleccionDGV();
            DatosDGV();
            
        }

        //Limpiar las seleciones de los dataGridView
        private void SeleccionDGV()
        {
            dataUsuarios.ClearSelection();
            dataRoles.ClearSelection();
            dataCargos.ClearSelection();
            dataCategorias.ClearSelection();
            
        }

        //Metodo de llenar los dataGridView
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

        //Boton de registrar
        private void BuRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbUsuarios.Checked)
                {
                    ControlUsuarios clUsuarios = new ControlUsuarios(idUser);
                    clUsuarios.ShowDialog();

                }
                else if (rbCargos.Checked)
                {
                    ControlCargos clCargos = new ControlCargos(idCargo);
                    clCargos.ShowDialog();
                }
                else if (rbRoles.Checked)
                {
                    ControlRoles clRoles = new ControlRoles(idRol);
                    clRoles.ShowDialog();
                }
                else if (rbCategorias.Checked)
                {
                    ControlCategorias clCategorias = new ControlCategorias(idCategoria);
                    clCategorias.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Debe marcar el tipo de registro que desea registrar", "informacion",
                                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "informacion",
                                    MessageBoxButtons.OK, MessageBoxIcon.Question);
            }  
        }

        //Boton de actualizar
        private void BuUpdate_Click(object sender, EventArgs e)
        {
            if (rbUsuarios.Checked)
            {
                if(dataUsuarios.SelectedRows.Count > 0)
                {
                    ControlUsuarios clUsuarios = new ControlUsuarios(idUser);
                    clUsuarios.ShowDialog();
                } 
                else
                {
                    MessageBox.Show($"Intento de actualizar un registro de usuario.\nDebe de seleccionar una fila da la tabla de usuarios.", "informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else if (rbCargos.Checked)
            {
                if(dataCargos.SelectedRows.Count > 0)
                {
                    ControlCargos clCargos = new ControlCargos(idCargo);
                    clCargos.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Intento de actualizar un registro de cargos de empleados.\nDebe de seleccionar una fila da la tabla de cargos.", "informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
                }                
            }
            else if (rbRoles.Checked)
            {
                if(dataRoles.SelectedRows.Count > 0)
                {
                    ControlRoles clRoles = new ControlRoles(idRol);
                    clRoles.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Intento de actualizar un registro de roles de usuaios.\nDebe de seleccionar una fila da la tabla de roles.", "informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else if (rbCategorias.Checked)
            {
                if(dataCategorias.SelectedRows.Count > 0)
                {
                    ControlCategorias clCategorias = new ControlCategorias(idCategoria);
                    clCategorias.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Intento de actualizar un registro de categorias de productos.\nDebe de seleccionar una fila da la tabla de Categorias.", "informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show($"Debe marcar el tipo de registro que desea actualizar", "informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        //Boton de eliminar
        private void BuDeleteE_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbUsuarios.Checked)
                {
                    if (dataUsuarios.SelectedRows.Count > 0)
                    {
                        var Mensaje = MessageBox.Show($"¿Desea eliminar este usuario?", "Eliminar usuario",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (Mensaje == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(dataUsuarios.CurrentRow.Cells["id_usuario"].Value);
                            Usuarios.EliminarUser(id);
                            MessageBox.Show($"usuario eliminado con exito!", "Eliminar cargo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                            DatosDGV();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Intento de eliminar un registro de usuario.\nDebe de seleccionar una fila da la tabla de usuarios.", "informacion",
                                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    } 
                }
                else if (rbCargos.Checked)
                {
                    if (dataCargos.SelectedRows.Count > 0)
                    {
                        var Mensaje = MessageBox.Show($"¿Desea eliminar este cargo?", "Eliminar cargo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (Mensaje == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(dataCargos.CurrentRow.Cells["id_cargo"].Value);
                            CargosEmpleados.EliminarCargos(id);
                            MessageBox.Show($"cargo eliminado con exito!", "Eliminar cargo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                            DatosDGV();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Intento de eliminar un registro de cargos de empleados.\nDebe de seleccionar una fila da la tabla de cargos.", "informacion",
                                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }   
                }
                else if (rbRoles.Checked)
                {
                    if (dataRoles.SelectedRows.Count > 0)
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
                    else
                    {
                        MessageBox.Show($"Intento de eliminar un registro de roles de usuaios.\nDebe de seleccionar una fila da la tabla de roles.", "informacion",
                                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }  
                }
                else if (rbCategorias.Checked)
                {
                    if (dataCategorias.SelectedRows.Count > 0)
                    {
                        var Mensaje = MessageBox.Show($"¿Desea eliminar esta categoria?", "Eliminar categoria",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (Mensaje == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(dataCategorias.CurrentRow.Cells["id_categoria"].Value);
                            Categorias.EliminarCategorias(id);
                            MessageBox.Show($"Categoria eliminada con exito!", "Eliminar categoria",
                                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                            DatosDGV();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Intento de eliminar un registro de categorias de productos.\nDebe de seleccionar una fila da la tabla de Categorias.", "informacion",
                                    MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                MessageBox.Show($"{ex.Message}", "informacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Question);
            }          
        }


        //Metodos para obtener los ids 
        private void dataUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            BuRegister.Visible = false;
            BuUpdate.Visible = true;
            BuDeleteE.Visible = true;
            BuNuevo.Visible = true;
            idUser = Convert.ToInt32(dataUsuarios.CurrentRow.Cells["id_usuario"].Value);
        }

        private void dataCargos_SelectionChanged(object sender, EventArgs e)
        {
            BuRegister.Visible = false;
            BuUpdate.Visible = true;
            BuDeleteE.Visible = true;
            BuNuevo.Visible = true;
            idCargo = Convert.ToInt32(dataCargos.CurrentRow.Cells["id_cargo"].Value);
        }

        private void dataCategorias_SelectionChanged(object sender, EventArgs e)
        {
            BuRegister.Visible = false;
            BuUpdate.Visible = true;
            BuDeleteE.Visible = true;
            BuNuevo.Visible = true;
            idCategoria = Convert.ToInt32(dataCategorias.CurrentRow.Cells["id_Categoria"].Value);
        }

        private void dataRoles_SelectionChanged(object sender, EventArgs e)
        {
            BuRegister.Visible = false;
            BuUpdate.Visible = true;
            BuDeleteE.Visible = true;
            BuNuevo.Visible = true;
            idRol = Convert.ToInt32(dataRoles.CurrentRow.Cells["id_rol"].Value);
        }

        //Control para los nuevos registros
        private void BuNuevo_Click(object sender, EventArgs e)
        {
            Inicio();
        }

        //Metodo de control de inicio
        private void Inicio()
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
