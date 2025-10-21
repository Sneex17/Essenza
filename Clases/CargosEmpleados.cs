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
    }
}
