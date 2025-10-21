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
        public static SqlConnection EssenzaDB()
        {
            try
            {
                SqlConnection ConexionDB = new SqlConnection("Data Source=DESKTOP-5F1MSU0;Initial Catalog=essenza_system_db;" +
                "Integrated Security=True;TrustServerCertificate=True");
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
