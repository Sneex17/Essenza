using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.Clases
{
    public class CargosEmpleados
    {
        public int id_cargo { get; set; }
        public string cargo { get; set; }
        public decimal salario { get; set; }


        //Metodo para obtener los datos de los cargos de los empleados
        public static List<CargosEmpleados> DatosCargos()
        {
            List<CargosEmpleados> listCargos = new List<CargosEmpleados>();
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = $"select * from cargos";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    CargosEmpleados cargos = new CargosEmpleados();
                    cargos.id_cargo = reader.GetInt32(0);
                    cargos.cargo = reader.GetString(1);
                    cargos.salario = reader.GetDecimal(2);
                    listCargos.Add(cargos);
                }
                reader.Close();
            }
            return listCargos;
        }

        //Metodo para obtener los datos de los salarios dependiendo el cargo del empleado
        public static Object DatosSalario(CargosEmpleados cargos)
        {
            string NewQuery = $"select salario from cargos where id_cargo = '{cargos.id_cargo}'";
            using(SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    cargos.id_cargo= reader.GetInt32(0);
                    cargos.cargo= reader.GetString(1);
                    cargos.salario= reader.GetDecimal(2);
                }
                reader.Close();
            }
            return cargos.salario;
        }

        //Agregar cargos de empleado
        public static void AgregarCargos(CargosEmpleados cargos)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = $"insert into cargos (cargo, salario) values (@cargo, @salario)";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@cargo", cargos.cargo);
                comando.Parameters.AddWithValue("@salario", cargos.salario);
                resultado = comando.ExecuteNonQuery();
            }

        }

        //Actualizar cargos del empleado
        public static void ActualizarCargos(CargosEmpleados cargos)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = @"update cargos set
                                    cargo = @cargo,
                                    salario = @salario
                                    where id_cargo = @id_cargo";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@id_cargo", cargos.id_cargo);
                comando.Parameters.AddWithValue("@cargo", cargos.cargo);
                comando.Parameters.AddWithValue("@salario", cargos.salario);
                resultado = comando.ExecuteNonQuery();
            }
        }

        //Eliminar cargos del empleado
        public static void EliminarCargos(int id)
        {
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                int resultado;
                string NewQuery = $"delete cargos where id_cargo = @id_cargo";
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue("@id_cargo", id);
                resultado = comando.ExecuteNonQuery();
            }
        }
    }
}
