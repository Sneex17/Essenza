using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essenza.Clases
{
    public class EssenzaSystemDB
    {
        //Metodo de conexion a la base de datos del sistema
        public static SqlConnection EssenzaDB()
        {
            try
            {
              

                SqlConnection ConexionDB = new SqlConnection("Data Source=DESKTOP-5F1MSU0;Initial " +
                    "Catalog=essenza_system_db;User ID=sa;Password=sa");


                ConexionDB.Open();
                return ConexionDB;
            }
            catch
            {
                MessageBox.Show($"Error con la base de datos", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }
        
    }
}
