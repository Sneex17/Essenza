using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.Clases
{
    public class Categorias
    {
        public int id_categoria {  get; set; }
        public string categoria { get; set; }

        //Lista de las categorias
        public static List<Categorias> listaCategorias()
        {
            List<Categorias> listcategorias = new List<Categorias>();

            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = @"select * from categorias";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Categorias categorias = new Categorias();
                    categorias.id_categoria = reader.GetInt32(0);
                    categorias.categoria = reader.GetString(1);
                    listcategorias.Add(categorias);
                }
                reader.Close();
            }
            return listcategorias;
        }
    }
}
