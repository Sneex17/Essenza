using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Essenza.Clases;

namespace Essenza.Clases
{
    public class Suplidores
    {
        public int id_suplidor {  get; set; }
        public string nombres { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public int id_pais { get; set; }
        public int id_estado { get; set; }


        //registrar suplidores
        public static void AgregarSuplidor(Suplidores suplidores)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = @"insert into suplidores (nombres, telefono, email, 
                       direccion, id_pais, id_estado) values (@nombres, @telefono, @email, @direccion, @id_pais, @id_estado)";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@nombres", suplidores.nombres);
                comando.Parameters.AddWithValue("@telefono", suplidores.telefono);
                comando.Parameters.AddWithValue("@email", suplidores.email);
                comando.Parameters.AddWithValue("@direccion", suplidores.direccion);
                comando.Parameters.AddWithValue("@id_pais", suplidores.id_pais);
                comando.Parameters.AddWithValue("@id_estado", suplidores.id_estado);
                resultado = comando.ExecuteNonQuery();
            }
        }

        //Actualizar datos suplidores
        public static void ActualizarSuplidor(Suplidores suplidores)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = @"update suplidores set
                        nombres = @nombres,
                        telefono = @telefono,
                        email = @email,
                        direccion = @direccion,
                        id_pais = @id_pais,
                        id_estado = @id_estado
                        where id_suplidor = @id_suplidor";

                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@id_suplidor", suplidores.id_suplidor);
                comando.Parameters.AddWithValue("@nombres", suplidores.nombres);
                comando.Parameters.AddWithValue("@telefono", suplidores.telefono);
                comando.Parameters.AddWithValue("@email", suplidores.email);
                comando.Parameters.AddWithValue("@direccion", suplidores.direccion);
                comando.Parameters.AddWithValue("@id_pais", suplidores.id_pais);
                comando.Parameters.AddWithValue("@id_estado", suplidores.id_estado);
                resultado = comando.ExecuteNonQuery();
            }
        }

        //Eliminar suplidore
        public static void EliminarSuplidor(Suplidores suplidores)
        {
            using(SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = @"delete suplidores where id_suplidor = @id_suplidor";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@id_suplidor", suplidores.id_suplidor);
                resultado = comando.ExecuteNonQuery();
            }
        }

        //Mostrar listado suplidores
        public static List<Suplidores> ListaSuplidores()
        {
            List<Suplidores> listSuplidores = new List<Suplidores>();
            using(SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = @"select * from suplidores";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Suplidores suplidores = new Suplidores();
                    suplidores.id_suplidor = reader.GetInt32(0);
                    suplidores.nombres = reader.GetString(1);
                    suplidores.telefono = reader.GetString(2);
                    suplidores.email = reader.GetString(3);
                    suplidores.direccion = reader.GetString(4);
                    suplidores.id_pais = reader.GetInt32(5);
                    suplidores.id_estado = reader.GetInt32(6);
                    listSuplidores.Add(suplidores);
                }
                reader.Close();
            }
            return listSuplidores;
        }
    }
}
