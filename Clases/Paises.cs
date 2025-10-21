using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.Clases
{
    public class Paises
    {
        public int id_pais {  get; set; }
        public string pais { get; set; }

        //Listado de paises
        public static List<Paises> DatosPaises()
        {
            List<Paises> listPais = new List<Paises>();
            using(SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = @"select * from paises";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Paises paises = new Paises();
                    paises.id_pais = reader.GetInt32(0);
                    paises.pais = reader.GetString(1);
                    listPais.Add(paises);
                }
                reader.Close();
            }
            return listPais;
        }
    }
}
