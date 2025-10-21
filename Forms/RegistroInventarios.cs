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
    }
}
