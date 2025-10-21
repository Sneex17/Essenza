using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.Clases
{
    public class Sexos
    {
        public int id_sexo {  get; set; }
        public string sexo { get; set; }

        public static List<Sexos> DatosSexos()
        {
            List<Sexos> listSexs = new List<Sexos>();
            using (SqlConnection conexion = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = $"select * from sexos";
                SqlCommand comando = new SqlCommand(NewQuery, conexion);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Sexos sexs = new Sexos();
                    sexs.id_sexo = leer.GetInt32(0);
                    sexs.sexo = leer.GetString(1);
                    listSexs.Add(sexs);
                }
                leer.Close();
                return listSexs;
            }
        }
    }
}
