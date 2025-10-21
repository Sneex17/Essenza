using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.Clases
{
    public class EstadosCiviles
    {
        public int id_estado_civil {  get; set; }
        public string estado_civil { get; set; }

        public static List<EstadosCiviles> DatosMaritalStatuses()
        {
            List<EstadosCiviles> listMariStatuses = new List<EstadosCiviles>();
            using (SqlConnection conexion = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = "select * from estados_civiles";
                SqlCommand comando = new SqlCommand(NewQuery, conexion);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EstadosCiviles maritalStatuses = new EstadosCiviles();
                    maritalStatuses.id_estado_civil = leer.GetInt32(0);
                    maritalStatuses.estado_civil = leer.GetString(1);
                    listMariStatuses.Add(maritalStatuses);  
                }
                leer.Close();
                return listMariStatuses;
            }
        }
    }
}
