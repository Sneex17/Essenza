using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.Clases
{
    public class Clientes
    {
        public int id_cliente {  get; set; }
        public string nombres { get; set;}
        public string apellidos { get; set;}
        public int id_sexo { get; set;}
        public int id_estado_civil { get; set;}
        public string cedula { get; set;}
        public string telefono { get; set;}
        public string email { get; set;}
        public string direccion {  get; set;}
        public int id_estado { get; set; }

        //Lista de los datos para el filtro
        public List<String> ListDatosClientesFiltro = new List<string>
        { 
            "id_cliente", "nombres", "apellidos", "id_sexo", "id_estado_civil",
            "cedula", "telefono", "email", "direccion", "id_estado"
        };

        //Registrar Clientes
        public static int RegistrarClientes(Clientes clientes)
        {
            int resultado;
            using(SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                String NewQuery = @"Insert into clientes (nombres, apellidos, id_sexo, id_estado_civil, 
                cedula, telefono, email, direccion, id_estado) values (@nombres, @apellidos, @id_sexo, @id_estado_civil, 
                @cedula, @telefono, @email, @direccion, @id_estado)";

                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@nombres", clientes.nombres);
                comando.Parameters.AddWithValue("@apellidos", clientes.apellidos);
                comando.Parameters.AddWithValue("@id_sexo", clientes.id_sexo);
                comando.Parameters.AddWithValue("id_estado_civil", clientes.id_estado_civil);
                comando.Parameters.AddWithValue("@cedula", clientes.cedula);
                comando.Parameters.AddWithValue("@telefono", clientes.telefono);
                comando.Parameters.AddWithValue("@email", clientes.email);
                comando.Parameters.AddWithValue("@direccion", clientes.direccion);
                comando.Parameters.AddWithValue("@id_estado", clientes.id_estado);
                resultado = comando.ExecuteNonQuery();
            }
            return resultado;
        }

        //Mostrar Datos de los Clientes
        public static List<Clientes> DatosClientes()
        {
            List<Clientes> listClientes = new List<Clientes>();
            using(SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                String NewQuery = $"Select * from clientes";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Clientes clientes = new Clientes();
                    clientes.id_cliente = reader.GetInt32(0);
                    clientes.nombres = reader.GetString(1);
                    clientes.apellidos = reader.GetString(2);
                    clientes.id_sexo = reader.GetInt32(3);
                    clientes.id_estado_civil = reader.GetInt32(4);
                    clientes.cedula = reader.GetString(5);
                    clientes.telefono = reader.GetString(6);
                    clientes.email = reader.GetString(7);
                    clientes.direccion = reader.GetString(8);
                    clientes.id_estado = reader.GetInt32(9);
                    listClientes.Add(clientes);
                }
                reader.Close();
            }
            return listClientes;
        }
        //Actualizar Datos del Cliente
        public static object ActualizarCliente(Clientes clientes)
        {
            int resultado;
            string NewQuery = @"UPDATE clientes SET
            nombres = @nombres,
            apellidos = @apellidos,
            id_sexo = @id_sexo,
            id_estado_civil = @id_estado_civil,
            cedula = @cedula,
            telefono = @telefono,
            email = @email,
            direccion = @direccion,
            id_estado = @id_estado
            WHERE id_cliente = @id_cliente";

            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@id_cliente", clientes.id_cliente);
                comando.Parameters.AddWithValue("@nombres", clientes.nombres);
                comando.Parameters.AddWithValue("apellidos", clientes.apellidos);
                comando.Parameters.AddWithValue("@id_sexo", clientes.id_sexo);
                comando.Parameters.AddWithValue("@id_estado_civil", clientes.id_estado_civil);
                comando.Parameters.AddWithValue("@cedula", clientes.cedula);
                comando.Parameters.AddWithValue("@telefono", clientes.telefono);
                comando.Parameters.AddWithValue("@email", clientes.email);
                comando.Parameters.AddWithValue("@direccion", clientes.direccion);
                comando.Parameters.AddWithValue("@id_estado", clientes.id_estado);
                resultado = comando.ExecuteNonQuery();
            }
            return resultado;
        }
        //Eliminar clientes
        public static object ElinimarCliente(Clientes clientes)
        {
            int resultado;
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                String NewQuery = $"delete from clientes where id_cliente = @id_cliente";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@id_cliente", clientes.id_cliente);
                resultado = comando.ExecuteNonQuery();
            }
            return resultado;
        }
    }
}
