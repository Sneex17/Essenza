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
using Essenza.FormsReportes;

namespace Essenza.Forms
{
    public partial class RegistroInventarios : Form
    {
        public RegistroInventarios()
        {
            InitializeComponent();
            DatosCbx();
            txtIdInv.Enabled = false;
        }
        private void DatosCbx()
        {
            DatosCategorias();
            DatosSuplidores();
        }
        private void DatosCategorias()
        {
            List<Categorias> list = Categorias.listaCategorias();
            {
                cbxCategoria.DataSource = list;
                cbxCategoria.ValueMember = "id_categoria";
                cbxCategoria.DisplayMember = "categoria";
            }
        }

        private void DatosSuplidores()
        {
            List<Suplidores> list = Suplidores.ListaSuplidores();
            {
                cbxSuplidor.DataSource = list;
                cbxSuplidor.ValueMember = "id_suplidor";
                cbxSuplidor.DisplayMember = "nombres";
            }

        }
        private void ClearTxt()
        {
            txtIdInv.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPcompras.Text = string.Empty;
            txtPventas.Text = string.Empty;
        }
        private void BuRegistroInventario_Click(object sender, EventArgs e)
        {
            Inventarios inventarios = new Inventarios();
            inventarios.id_suplidor = Convert.ToInt32(cbxSuplidor.SelectedValue);
            inventarios.producto = txtProducto.Text;
            inventarios.descripcion = txtDescripcion.Text;
            inventarios.cantidad = Convert.ToInt32(txtCantidad.Text);
            inventarios.precio_compra = Convert.ToDecimal(txtPcompras.Text);
            inventarios.precio_venta = Convert.ToDecimal(txtPventas.Text);
            inventarios.id_categoria = Convert.ToInt32(cbxCategoria.SelectedValue);
            inventarios.fecha_ingreso = Convert.ToDateTime(dateIngreso.Text);

            DateTime Today = DateTime.Now;
            if(inventarios.fecha_ingreso > Today)
            {
                MessageBox.Show($"La fecha debe ser menor o igual al dia de hoy: {Today}", "Error de fecha",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (inventarios.cantidad <= 0)
            {
                MessageBox.Show($"La cantidad debe ser mayor o igual al 1, " +
                    $"usted ingreso una cantidad de: {inventarios.cantidad} unicades", "Error de cantidad",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (inventarios.precio_compra <= 0)
            {
                MessageBox.Show($"El precio de compra debe ser mayor o igual al 1.00, " +
                    $"usted ingreso un precio de compra de: {inventarios.precio_compra} dolares", "Error de cantidad",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (inventarios.precio_venta <= inventarios.precio_compra)
            {
                MessageBox.Show($"El precio de venta debe ser mayor al precio de compra, " +
                    $"usted ingreso un precio de venta de: {inventarios.precio_venta} dolares y el " +
                    $"precio de compra es de: {inventarios.precio_compra}", "Error de cantidad",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var mensaje = MessageBox.Show($"¿Desea registrar este producto como inventario?", "Registro de Inventarios",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(mensaje == DialogResult.Yes)
                {
                    Inventarios.RegistrarInvetarios(inventarios);
                    MessageBox.Show($"Inventario registrado con exito!", "Registro de Inventarios",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTxt();
                }
            }


        }

        private void BuBuscarE_Click(object sender, EventArgs e)
        {
            ReportesInventarios reportesInventarios = new ReportesInventarios();

            reportesInventarios.SelecionalInventario += (inventarios) =>
            {
                txtIdInv.Text = inventarios.id_inventario.ToString();
                cbxSuplidor.SelectedValue = inventarios.id_suplidor;
                txtProducto.Text = inventarios.producto;
                txtDescripcion.Text = inventarios.descripcion;
                txtCantidad.Text = inventarios.cantidad.ToString();
                txtPcompras.Text = inventarios.precio_compra.ToString();
                txtPventas.Text = inventarios.precio_venta.ToString();
                cbxCategoria.SelectedValue = inventarios.id_categoria;
                dateIngreso.Value = inventarios.fecha_ingreso;
            };
            reportesInventarios.ShowDialog();
        }

        private void BuUpdateInventario_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtIdInv.Text))
            {
                MessageBox.Show($"Debe buscar y selecional un inventario para actualizar sus datos",
               "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Inventarios inventarios = new Inventarios();
                inventarios.id_inventario = Convert.ToInt32(txtIdInv.Text);
                inventarios.id_suplidor = Convert.ToInt32(cbxSuplidor.SelectedValue);
                inventarios.producto = txtProducto.Text;
                inventarios.descripcion = txtDescripcion.Text;
                inventarios.cantidad = Convert.ToInt32(txtCantidad.Text);
                inventarios.precio_compra = Convert.ToDecimal(txtPcompras.Text);
                inventarios.precio_venta = Convert.ToDecimal(txtPventas.Text);
                inventarios.id_categoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                inventarios.fecha_ingreso = Convert.ToDateTime(dateIngreso.Text);

                DateTime Today = DateTime.Now;
                if (inventarios.fecha_ingreso > Today)
                {
                    MessageBox.Show($"La fecha debe ser menor o igual al dia de hoy: {Today}", "Error de fecha",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (inventarios.cantidad <= 0)
                {
                    MessageBox.Show($"La cantidad debe ser mayor o igual al 1, " +
                        $"usted ingreso una cantidad de: {inventarios.cantidad} unicades", "Error de cantidad",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (inventarios.precio_compra <= 0)
                {
                    MessageBox.Show($"El precio de compra debe ser mayor o igual al 1.00, " +
                        $"usted ingreso un precio de compra de: {inventarios.precio_compra} dolares", "Error de cantidad",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (inventarios.precio_venta <= inventarios.precio_compra)
                {
                    MessageBox.Show($"El precio de venta debe ser mayor al precio de compra, " +
                        $"usted ingreso un precio de venta de: {inventarios.precio_venta} dolares y el " +
                        $"precio de compra es de: {inventarios.precio_compra}", "Error de cantidad",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var mensaje = MessageBox.Show($"¿Desea actualizar los datos de este inventario?", "Actualizacion de Inventarios",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        Inventarios.ActualizarInventario(inventarios);
                        MessageBox.Show($"Datos del inventario actualizados con exito!", "Actualizacion de Inventarios",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTxt();
                    }
                }
            }
        }

        private void BuDeleteInventario_Click(object sender, EventArgs e)
        {
            var mensaje = MessageBox.Show($"¿Desea eliminar este inventario?", "Eliminacion de Inventarios",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(mensaje == DialogResult.Yes)
            {
                if (String.IsNullOrWhiteSpace(txtIdInv.Text))
                {
                    MessageBox.Show($"Debe buscar y selecional un inventario para elinimarlo",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Inventarios inventarios = new Inventarios();
                    inventarios.id_inventario = Convert.ToInt32(txtIdInv.Text);
                    Inventarios.EliminarInventarios(inventarios);
                    MessageBox.Show($"Inventario eliminado con exito!", "Eliminacion de Inventarios",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTxt();
                }
            }
            
        }

        private void BuExit_Click(object sender, EventArgs e) => this.Close();
       
    }
}
