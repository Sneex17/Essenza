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
        int idUser;
        public event Action<Usuarios> MoverDatosUser;
        public ControlAdmin()
        {
            InitializeComponent();
            DatosDGV();
        }


        private void DatosDGV()
        {
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

            }
            else if (rbCategorias.Checked)
            {

            }
            else
            {

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

            }
            else if (rbCategorias.Checked)
            {

            }
            else
            {

            }
        }

        private void dataUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idUser = Convert.ToInt32(dataUsuarios.CurrentRow.Cells["id_usuario"].Value);
        }


        //Salir de la ventana
        private void BuExit_Click(object sender, EventArgs e) => this.Close();

        private void dataUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
