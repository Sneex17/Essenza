using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.Clases
{
    public class Inventarios
    {
        public int id_inventario {  get; set; }
        public int id_suplidor { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }
        public decimal precio_compra {  get; set; }
        public decimal precio_venta { get; set; }
        public int id_categoria { get; set; }
        public DateTime fecha_ingreso { get; set; }

        //Monstrar Datos del Invetario
        public static List<Inventarios> DatosInventarios()
        {
            List<Inventarios > listInve = new List<Inventarios>();

            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = $"select * from inventarios";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.HasRows)
                {
                    Inventarios inventarios = new Inventarios();
                    inventarios.id_inventario = reader.GetInt32(0);
                    inventarios.id_suplidor = reader.GetInt32(1);
                    inventarios.producto = reader.GetString(2);
                    inventarios.cantidad = reader.GetInt32(3);
                    inventarios.precio_compra = reader.GetDecimal(4);
                    inventarios.precio_venta = reader.GetDecimal(5);
                    inventarios.id_categoria = reader.GetInt32(6);
                    inventarios.fecha_ingreso = reader.GetDateTime(7);
                    listInve.Add(inventarios);
                }
            }
            return listInve;
        }

        //Registrar Invetarios nuevos
        public static int RegistrarInvetarios(Inventarios inventarios)
        {
            int resultado;
            string NewQuery = @"insert into inventarios (id_suplidor, producto, cantidad, 
                precio_compra, precio_venta, id_categoria, fecha_ingreso) values (@id_suplidor, @producto, @cantidad, 
                @precio_compra, @precio_venta, @id_categoria, @fecha_ingreso)";

            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue(@"id_suplidor", inventarios.id_suplidor);
                comando.Parameters.AddWithValue(@"producto", inventarios.producto);
                comando.Parameters.AddWithValue(@"cantidad", inventarios.cantidad);
                comando.Parameters.AddWithValue(@"precio_compra", inventarios.precio_compra);
                comando.Parameters.AddWithValue(@"precio_venta", inventarios.precio_venta);
                comando.Parameters.AddWithValue(@"id_categoria", inventarios.id_categoria);
                comando.Parameters.AddWithValue(@"fecha_ingreso", inventarios.fecha_ingreso);
                resultado = comando.ExecuteNonQuery();
            }
            return resultado;
        }

        //Eliminar inventarios
        public static int EliminarInventarios(Inventarios inventarios)
        {
            int resultado;
            string NewQuery = $"Delete inventarios where id_inventario = @id_inventario";
            using(SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                SqlCommand comando = new SqlCommand(NewQuery,acceso);
                comando.Parameters.AddWithValue(@"id_inventario", inventarios.id_inventario);
                resultado= comando.ExecuteNonQuery();
            }
            return resultado;
        }
    }
}
