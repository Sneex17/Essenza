using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.Clases
{
    public class Roles
    {
        public int id_rol {  get; set; }
        public string rol { get; set; }

        //Metodo para obtener los datos de los roles
        public static string UserRol(Roles roles)
        {
            string NewQuery = @"select rol from roles where id_rol = @id_rol";
            using(SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue(@"id_rol", roles.id_rol);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    roles.rol = (string)reader["rol"];
                }
                reader.Close();
            }
            return roles.rol;
        }

        //Metodo para la lista de los roles
        public static List<Roles> listaRoles()
        {
            string NewQuery = @"select * from roles";
            List<Roles> list = new List<Roles>();
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Roles roles = new Roles(); 
                    roles.id_rol = (int)reader["id_rol"];
                    roles.rol = (string)reader["rol"];
                    list.Add(roles);
                }
                reader.Close();
                return list;
            }
            
        }

        //Agregar Roles
        public static void AgregarRol(Roles roles)
        {
            using(SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = $"insert into roles (rol) values (@rol)";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@rol", roles.rol);
                resultado = comando.ExecuteNonQuery();
            }
        }

        //Actualizar Roles
        public static void ActualizarRol(Roles roles)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = @"update roles set rol = @rol where id_rol = @id_rol";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@id_rol", roles.id_rol);
                comando.Parameters.AddWithValue("@rol", roles.rol);
                resultado = comando.ExecuteNonQuery();
            }
        }

        //Eliminar Roles
        public static void EliminarRol(int id)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = @"delete roles where id_rol = @id_rol";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@id_rol", id);
                resultado = comando.ExecuteNonQuery();
            }
        }

    }
}
