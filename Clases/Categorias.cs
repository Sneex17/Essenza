using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Essenza.Clases
{
    public class Categorias
    {
        public int id_categoria {  get; set; }
        public string categoria { get; set; }

        //Metodo para obtener los datos de las categorias de los productos
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

        //Agregar categorias
        public static void AgregarCategorias(Categorias categorias)
        {
            using(SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = $"insert into categorias (categoria) values (@categoria)";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@categoria", categorias.categoria);
                resultado = comando.ExecuteNonQuery();
            }
        }

        //Actualizar categorias
        public static void ActualizarCategorias(Categorias categorias)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = $"update categorias set categoria = @categoria where id_categoria = @id_categoria";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@id_categoria", categorias.id_categoria);
                comando.Parameters.AddWithValue("@categoria", categorias.categoria);
                resultado = comando.ExecuteNonQuery();
            }
        }

        //Eliminar categorias
        public static void EliminarCategorias(int id)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = $"delete categorias where id_categoria = @id_categoria";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@id_categoria", id);
                resultado = comando.ExecuteNonQuery();
            }
        }
    }
}
