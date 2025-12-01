using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class ControlCategorias : Form
    {
        Categorias categorias = new Categorias();
        public ControlCategorias(int? idCategoria)
        {
            InitializeComponent();
            idcategorias(idCategoria);
            controlTxt();
            datosCategoria();

        }

        private void controlTxt()
        {
            txtIdCategoria.Enabled = false;
        }
        private void idcategorias(int? id)
        {
            if(id != null)
                categorias.id_categoria = Convert.ToInt32(id);
        }

        private void datosCategoria()
        {
            int id = categorias.id_categoria;
            List<Categorias> listCategorias = Categorias.listaCategorias();
            var datos = from u in listCategorias where u.id_categoria == id select u;

            foreach(var u in datos)
            {
                txtIdCategoria.Text = u.id_categoria.ToString();
                txtCategoria.Text = u.categoria.ToString();
            }
        }

        private void BuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtIdCategoria.Text))
                {
                    var Mensaje = MessageBox.Show($"¿Desea agregar esta categoria de producto?", "Agregar categoria",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Mensaje == DialogResult.Yes)
                    {
                        Categorias categorias = new Categorias();
                        categorias.categoria = txtCategoria.Text;
                        Categorias.AgregarCategorias(categorias);
                        MessageBox.Show($"Categoria de producto agregada con exito!", "Agregar categoria",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    var Mensaje = MessageBox.Show($"¿Desea actualizar los datos de esta categoria?", "Actualizar categoria",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Mensaje == DialogResult.Yes)
                    {
                        Categorias categorias = new Categorias();
                        categorias.id_categoria = Convert.ToInt32(txtIdCategoria.Text);
                        categorias.categoria = txtCategoria.Text;
                        Categorias.ActualizarCategorias(categorias);
                        MessageBox.Show($"datos de la categoria actualizados con exito!", "Actualizar categoria",
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
