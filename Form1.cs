using Essenza.Clases;
using Essenza.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essenza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("favor de ingresar su usuario", "Informacion",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (String.IsNullOrWhiteSpace(txtPass.Text))
                {
                    MessageBox.Show("favor de ingresar su contraseña", "Informacion",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    Usuarios usuarios = new Usuarios();
                    usuarios.usuario = txtUser.Text;
                    usuarios.pass = txtPass.Text;

                    using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
                    {
                        string NewQuery = $"select * from usuarios where usuario = '{usuarios.usuario}'";
                        SqlCommand cmd = new SqlCommand(NewQuery, acceso);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader.HasRows == true)
                            {
                                string NewQuery2 = $"select * from usuarios where pass = '{usuarios.pass}'";
                                using (SqlConnection verificacion = EssenzaSystemDB.EssenzaDB())
                                {
                                    SqlCommand cmd2 = new SqlCommand(NewQuery2, verificacion);
                                    SqlDataReader reader2 = cmd2.ExecuteReader();
                                    while (reader2.Read())
                                    {
                                        if (reader2.HasRows == true)
                                        {
                                            MenuPrincipal principal = new MenuPrincipal(usuarios);
                                            principal.Show();
                                            this.Hide();
                                            Usuarios.UltimoAcceso(usuarios);
                                            MessageBox.Show($"Bienvenido {usuarios.usuario}", "Informacion",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Cotraseña incorrecta", "Informacion",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    reader2.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("usuario no encontrado", "Informacion",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        reader.Close();
                    }
                }
            }

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == Convert.ToChar(Keys.Enter)) txtPass.Focus(); }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == Convert.ToChar(Keys.Enter)) txtUser.Focus(); }


    }
}
