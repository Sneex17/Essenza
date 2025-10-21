using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.Clases
{
    public class Usuarios
    { 
        public int id_usuario {  get; set; }
        public string usuario { get; set; }
        public string pass { get; set; }
        public int id_rol {  get; set; }
        public int id_estado { get; set; }
        public DateTime fecha_creacion {  get; set; }
        public DateTime ultimo_acceso { get; set; }

        //actualizar el ultimo acceso de los usuarios
        public static int UltimoAcceso(Usuarios usuarios)
        {
            int resultado;
            usuarios.ultimo_acceso = DateTime.Now;
            
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = @"UPDATE usuarios SET ultimo_acceso = @ultimo_acceso WHERE usuario = @usuario";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@usuario", usuarios.usuario);
                comando.Parameters.AddWithValue("@ultimo_acceso", usuarios.ultimo_acceso);
                resultado = comando.ExecuteNonQuery();
            }
            return resultado;
        }

        public static int rol(Usuarios usuarios)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                String NewQuery = $"Select id_rol from Usuarios where usuario = @usuario and pass = @pass";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@usuario", usuarios.usuario);
                comando.Parameters.AddWithValue("@pass", usuarios.pass);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    usuarios.id_rol = (int)reader["id_rol"];
                }
                reader.Close();
            }
            return usuarios.id_rol;
        }
    }
}
