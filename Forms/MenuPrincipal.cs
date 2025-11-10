using Essenza.Clases;
using System;
using Essenza.FormsReportes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Essenza.ViewsAdmin;
using Essenza.FormsVentasYFacturas;
using System.Windows.Forms.DataVisualization.Charting;
using Essenza.ClasesAR;

namespace Essenza.Forms
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(Usuarios usuarios)
        {
            InitializeComponent();
            offSubMenu();
            Rol(usuarios);
            TopProductos();
        }

        private void users(Usuarios usuarios)
        {
            Roles roles = new Roles();
            roles.id_rol = usuarios.id_rol;

            LBrol.Text = Roles.UserRol(roles);
            LbWelcome.Text = $"Welcome {usuarios.usuario}";
            LbIDuser.Text = Convert.ToString(Usuarios.UserID(usuarios));
        }
        private void Rol(Usuarios usuarios)
        {
            usuarios.id_rol = Usuarios.rol(usuarios);

            switch (usuarios.id_rol)
            {
                case 1: //Administrador General
                    {
                        users(usuarios);
                    }
                    break;

                case 2: //Administrador de Clientes y Empleados
                    {
                        BuSuplidores.Enabled = false;
                        BnInventario.Enabled = false;
                        BuVentas.Enabled = false;
                        BuDashBoard.Visible = false;
                        users(usuarios);
                    }
                    break;

                case 3: //Administrador de Suplidores e Inventarios
                    {
                        BuClientes.Enabled = false;
                        BuEmpleados.Enabled = false;
                        BuVentas.Enabled = false;
                        BuDashBoard.Visible = false;
                        users(usuarios);
                    }
                    break;

                case 4: //Administrador de Ventas
                    {
                        BuSuplidores.Enabled = false;
                        BnInventario.Enabled = false;
                        BuClientes.Enabled = false;
                        BuEmpleados.Enabled = false;
                        BuDashBoard.Visible = false;
                        users(usuarios);
                    }
                    break;
            }

        }
        private void offSubMenu()
        {
            panelClientesSM.Visible = false;
            panelEmpleadosSM.Visible = false;
            panelInventarioSM.Visible = false;
            panelSuplidoresSM.Visible = false;
            panelVentasSM.Visible = false;
            panelDashBoard.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelClientesSM.Visible == true) { panelClientesSM.Visible = false; }
            if (panelEmpleadosSM.Visible == true) { panelEmpleadosSM.Visible = false; }
            if (panelInventarioSM.Visible == true) { panelInventarioSM.Visible = false;}
            if (panelSuplidoresSM.Visible == true) { panelSuplidoresSM.Visible = false;}
            if(panelVentasSM.Visible == true) { panelVentasSM.Visible = false;}
            if(panelDashBoard.Visible == true) { panelDashBoard.Visible = false;}
            
        }
        private void showSubMenu(Panel SubMenu)
        {
            if(SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }
        //Metodo para abrir los formularios
        private Form FormActive = null;
        private void OpenForms(Form FormChild)
        {
            if (FormActive != null)
            {
                FormActive.Close();
            }
            FormActive = FormChild;
            FormChild.TopLevel = false;
            FormChild.FormBorderStyle = FormBorderStyle.None;
            FormChild.Dock = DockStyle.Fill;
            panelMenuPrincipal.Controls.Add(FormChild);
            panelMenuPrincipal.Tag = FormChild;
            FormChild.BringToFront();
            FormChild.Show();

        }

        private void TopProductos()
        {
            List<Facturas> list = Facturas.DatosFacturas();
            var listTop = from t in list select (new {t.id_cliente, t.total_pagado });
            GraficaProducts.Series.Clear();
            Series serie = GraficaProducts.Series.Add("Top 10");
            foreach (var i in list)
            {
                
                serie.Points.AddY(i.total_pagado);
                serie.Points.Add(i.id_cliente);
                
            }
        }
        private void BuExit_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }

        private void BuClientes_Click(object sender, EventArgs e) => showSubMenu(panelClientesSM); 
        private void BuEmpleados_Click(object sender, EventArgs e) => showSubMenu(panelEmpleadosSM); 
        private void BuSuplidores_Click(object sender, EventArgs e) => showSubMenu(panelSuplidoresSM);
        private void BnInventario_Click(object sender, EventArgs e) => showSubMenu(panelInventarioSM); 
        private void BuVentas_Click(object sender, EventArgs e) =>  showSubMenu(panelVentasSM);
        private void BuDashBoard_Click(object sender, EventArgs e) => showSubMenu(panelDashBoard);

        private void BuRegistrarClientes_Click(object sender, EventArgs e) 
        {
            OpenForms(new RegistroClientes());
        }

        private void BuRegistrarEmpleados_Click(object sender, EventArgs e)
        {
            OpenForms(new RegistrationEmployee());
        }

        private void BuReportesEmpleados_Click(object sender, EventArgs e)
        {
            OpenForms(new EmployeeReports());
        }

        private void BuReportesClientes_Click(object sender, EventArgs e)
        {
            OpenForms(new ReportesClientes());
        }

        private void BuRegistrarInventario_Click(object sender, EventArgs e)
        {
            OpenForms(new RegistroInventarios());
        }

        private void BuReportesInventarios_Click(object sender, EventArgs e)
        {
            OpenForms(new ReportesInventarios());
        }

        private void BuRegistrarSuplidores_Click(object sender, EventArgs e)
        {
            OpenForms(new RegistroSuplidores());
        }

        private void BuAcercaDe_Click(object sender, EventArgs e)
        {
            OpenForms(new AcercaDe());
        }

        private void BuReportesSuplidores_Click(object sender, EventArgs e)
        {
            OpenForms(new ReportesSuplidores());
        }

        private void BuVender_Click(object sender, EventArgs e)
        {
            OpenForms(new FormVender());
        }

        private void BuEstadisticas_Click(object sender, EventArgs e)
        {
            OpenForms(new Dashboard());
        }

        private void BuReportesVentas_Click(object sender, EventArgs e)
        {
            OpenForms(new ReportesVentas());
        }
    }
}
