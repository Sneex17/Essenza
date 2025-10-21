using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.Clases
{
    public class Estados
    {
        public int id_estado {  get; set; }
        public string estado { get; set; }

        public static List<Estados> DatosEstados()
        {
            List<Estados> listEmployeeStatues = new List<Estados>();
            using(SqlConnection conexion = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = "select * from estados";
                SqlCommand comando = new SqlCommand(NewQuery, conexion);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Estados empStatues = new Estados();
                    empStatues.id_estado = leer.GetInt32(0);
                    empStatues.estado = leer.GetString(1);
                    listEmployeeStatues.Add(empStatues);
                }
                leer.Close();
                return listEmployeeStatues;
            }
        }
    }
}
