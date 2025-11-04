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

        //Rol del Usuario
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
    }
}
