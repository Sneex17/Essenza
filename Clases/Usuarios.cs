using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.Clases
{
    public class Usuarios : Empleados
    {
        

        public int id_usuario {  get; set; }
        public string usuario { get; set; }
        public string pass { get; set; }
        public int id_rol {  get; set; }
        //public int id_estado { get; set; }
        public DateTime fecha_creacion {  get; set; }
        public DateTime ultimo_acceso { get; set; }

        //Agregar Usuarios
        public static void AgregarUsuarios(Usuarios usuarios)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = @"insert into usuarios (id_empleado, usuario, pass, 
                                     id_rol, id_estado, fecha_creacion, ultimo_acceso)
                                    values (@id_empleado, @usuario, @pass, @id_rol, @id_estado, 
                                     @fecha_creacion, @ultimo_acceso)"; 
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@id_empleado", usuarios.id_empleado);
                comando.Parameters.AddWithValue("@usuario", usuarios.usuario);
                comando.Parameters.AddWithValue("@pass", usuarios.pass);
                comando.Parameters.AddWithValue("@id_rol", usuarios.id_rol);
                comando.Parameters.AddWithValue("@id_estado", usuarios.id_estado);
                comando.Parameters.AddWithValue("@fecha_creacion", usuarios.fecha_creacion);
                comando.Parameters.AddWithValue("@ultimo_acceso", usuarios.ultimo_acceso);

                resultado = comando.ExecuteNonQuery();
            }
        }

        //Actualizar Usuarios
        public static void UpdateUsuarios(Usuarios usuarios)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = @"Update usuarios set
                    usuario = @usuario,
                    pass = @pass,
                    id_rol = @id_rol,
                    id_estado = @id_estado
                    where id_usuario = @id_usuario";

                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@id_usuario", usuarios.id_usuario);
                comando.Parameters.AddWithValue("@usuario", usuarios.usuario);
                comando.Parameters.AddWithValue("@pass", usuarios.pass);
                comando.Parameters.AddWithValue("@id_rol", usuarios.id_rol);
                comando.Parameters.AddWithValue("@id_estado", usuarios.id_estado);
                

                resultado = comando.ExecuteNonQuery();
            }
        }

        //Eliminar usuarios
        public static void EliminarUser(int id)
        {
            using(SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = $"delete usuarios where id_usuario = {id}";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                resultado = comando.ExecuteNonQuery();
            }
        }
        //Lista de usuarios
        public static List<Usuarios> ListaUsuarios()
        {
            List<Usuarios> listUser = new List<Usuarios>();

            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = $"select * from usuarios"; 
                SqlCommand comado = new SqlCommand(NewQuery, acceso);

                SqlDataReader reader = comado.ExecuteReader();

                while (reader.Read())
                {
                    Usuarios usuarios = new Usuarios();

                    usuarios.id_usuario = reader.GetInt32(0);
                    usuarios.id_empleado = reader.GetInt32(1);
                    usuarios.usuario = reader.GetString(2);
                    usuarios.pass = reader.GetString(3);
                    usuarios.id_rol = reader.GetInt32(4);
                    usuarios.id_estado = reader.GetInt32(5);
                    usuarios.fecha_creacion = reader.GetDateTime(6);
                    usuarios.ultimo_acceso = reader.GetDateTime(7);
                    listUser.Add(usuarios);
                }
                reader.Close();
            }

            return listUser;
        }

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


        //Metodo para obtener el rol del usuario
        public static int rol(Usuarios usuarios)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = $"Select id_rol from Usuarios where usuario = @usuario and pass = @pass";
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

        //Metodo para obtener el id del usuario
        public static int UserID(Usuarios usuarios)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = $"Select id_usuario from Usuarios where usuario = @usuario and pass = @pass";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@usuario", usuarios.usuario);
                comando.Parameters.AddWithValue("@pass", usuarios.pass);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    usuarios.id_usuario = (int)reader["id_usuario"];
                }
                reader.Close();
            }
            return usuarios.id_usuario;
        }


        //Metodo para verificar la existencia de un usuario
        public static List<Usuarios> VerificacionUsuarios()
        {
            List<Usuarios> listU = new List<Usuarios>();
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = $"select * from Usuarios";
                SqlCommand comando = new SqlCommand(NewQuery,acceso);
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    Usuarios usuarios = new Usuarios();
                    usuarios.usuario = (string)reader["usuario"];
                    usuarios.pass = (string)reader["pass"];
                    listU.Add(usuarios);
                }
                reader.Close();

            }
            return listU;
            
        }
    }
}
