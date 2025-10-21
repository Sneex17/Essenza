using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Essenza.Clases
{
    public class Empleados
    {
        public int id_empleado { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int id_sexo { get; set; }
        public int id_estado_civil { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public int edad { get; set; }
        public DateTime fecha_contrato { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public int id_cargo { get; set; }
        public decimal salario { get; set; }
        public int id_estado { get; set; }

        //Lista para el filtro de datos
        public List<String> ListDatosFiltro = new List<String>()
        {
            "id_empleado", "nombres", "apellidos", "id_sexo", "id_estado_civil", "fecha_nacimiento",
            "edad", "fecha_contrato", "telefono" , "email", "direccion", "id_cargo", "salario", "id_estado"

        };

        //calcular edad
        public static object AgeEmployee(Empleados employees)
        {
            DateTime Today  = DateTime.Today;

            employees.edad = Today.Year - employees.fecha_nacimiento.Year;
            if (Today.Month < employees.fecha_nacimiento.Month || 
                (Today.Month == employees.fecha_nacimiento.Month && 
                Today.Day < employees.fecha_nacimiento.Day))
            {
                employees.edad--;
            }
            return employees.edad;  
        }

        //Agregar Empleado
        public static int AddEmployee(Empleados employees)
        {
            int resultado;
            string NewQuery = @"INSERT INTO empleados 
            (nombres, apellidos, id_sexo, id_estado_civil, fecha_nacimiento, edad, fecha_contrato, telefono, email, direccion, id_cargo, salario, id_estado) 
            VALUES (@nombres, @apellidos, @id_sexo, @id_estado_civil, @fecha_nacimiento, @edad, @fecha_contrato, @telefono, @email, @direccion, @id_cargo, @salario, @id_estado)";
            using(SqlConnection access = EssenzaSystemDB.EssenzaDB())
            {
                SqlCommand comando = new SqlCommand(NewQuery, access);
                comando.Parameters.AddWithValue("@nombres", employees.nombres);
                comando.Parameters.AddWithValue("@apellidos", employees.apellidos);
                comando.Parameters.AddWithValue("@id_sexo", employees.id_sexo);
                comando.Parameters.AddWithValue("@id_estado_civil", employees.id_estado_civil);
                comando.Parameters.AddWithValue("@fecha_nacimiento", employees.fecha_nacimiento);
                comando.Parameters.AddWithValue("@edad", employees.edad);
                comando.Parameters.AddWithValue("@fecha_contrato", employees.fecha_contrato);
                comando.Parameters.AddWithValue("@telefono", employees.telefono);
                comando.Parameters.AddWithValue("@email", employees.email);
                comando.Parameters.AddWithValue("@direccion", employees.direccion);
                comando.Parameters.AddWithValue("@id_cargo", employees.id_cargo);
                comando.Parameters.AddWithValue("@salario", employees.salario);
                comando.Parameters.AddWithValue("@id_estado", employees.id_estado);
                resultado = comando.ExecuteNonQuery();
            }
            return resultado;
        }

        //Actualizar Datos del Empleado
        public static int UpdateEmployee(Empleados employees)
        {
            int resultado;
            string NewQuery = @"UPDATE empleados SET
            nombres = @nombres,
            apellidos = @apellidos,
            id_sexo = @id_sexo,
            id_estado_civil = @id_estado_civil,
            fecha_nacimiento = @fecha_nacimiento,
            edad = @edad,
            fecha_contrato = @fecha_contrato,
            telefono = @telefono,
            email = @email,
            direccion = @direccion,
            id_cargo = @id_cargo,
            salario = @salario,
            id_estado = @id_estado
            WHERE id_empleado = @id_empleado";
           
            using (SqlConnection access = EssenzaSystemDB.EssenzaDB())
            {
                SqlCommand comando = new SqlCommand(NewQuery, access);
                comando.Parameters.AddWithValue("@id_empleado", employees.id_empleado);
                comando.Parameters.AddWithValue("@nombres", employees.nombres);
                comando.Parameters.AddWithValue("@apellidos", employees.apellidos);
                comando.Parameters.AddWithValue("@id_sexo", employees.id_sexo);
                comando.Parameters.AddWithValue("@id_estado_civil", employees.id_estado_civil);
                comando.Parameters.AddWithValue("@fecha_nacimiento", employees.fecha_nacimiento);
                comando.Parameters.AddWithValue("@edad", employees.edad);
                comando.Parameters.AddWithValue("@fecha_contrato", employees.fecha_contrato);
                comando.Parameters.AddWithValue("@telefono", employees.telefono);
                comando.Parameters.AddWithValue("@email", employees.email);
                comando.Parameters.AddWithValue("@direccion", employees.direccion);
                comando.Parameters.AddWithValue("@id_cargo", employees.id_cargo);
                comando.Parameters.AddWithValue("@salario", employees.salario);
                comando.Parameters.AddWithValue("@id_estado", employees.id_estado);
                resultado = comando.ExecuteNonQuery();
            }
            return resultado;
        }

        //Eliminar Empleado
        public static int DeleteEmployee(Empleados employees)
        {
            int resultado;
            string NewQuery = $"DELETE FROM empleados WHERE id_empleado = {employees.id_empleado}";
            using(SqlConnection conexion = EssenzaSystemDB.EssenzaDB())
            {
                SqlCommand comando = new SqlCommand(NewQuery, conexion);
                resultado = comando.ExecuteNonQuery();
            }
            return resultado;
        }
        public static List<Empleados> DatosReportsE()
        {
            List<Empleados> resultado = new List<Empleados>();
            using(SqlConnection conexion = EssenzaSystemDB.EssenzaDB())
            {
                string NewQuery = "select * from empleados";
                SqlCommand comando = new SqlCommand(NewQuery, conexion);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Empleados employees = new Empleados();
                    employees.id_empleado = leer.GetInt32(0);
                    employees.nombres = leer.GetString(1);
                    employees.apellidos = leer.GetString(2);
                    employees.id_sexo = leer.GetInt32(3);
                    employees.id_estado_civil = leer.GetInt32(4);
                    employees.fecha_nacimiento = leer.GetDateTime(5);
                    employees.edad = leer.GetInt32(6);
                    employees.fecha_contrato = leer.GetDateTime(7);
                    employees.telefono = leer.GetString(8);
                    employees.email = leer.GetString(9);
                    employees.direccion = leer.GetString(10);
                    employees.id_cargo = leer.GetInt32(11);
                    employees.salario = leer.GetDecimal(12);
                    employees.id_estado = leer.GetInt32(13);
                    resultado.Add(employees);
                }
                leer.Close();
                return resultado;
            }
        }

        public static List<Empleados> DatosReportsEFiltro(String NewQuery)
        {
            List<Empleados> resultado = new List<Empleados>();
            using (SqlConnection conexion = EssenzaSystemDB.EssenzaDB())
            {
                
                SqlCommand comando = new SqlCommand(NewQuery, conexion);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Empleados employees = new Empleados();
                    employees.id_empleado = leer.GetInt32(0);
                    employees.nombres = leer.GetString(1);
                    employees.apellidos = leer.GetString(2);
                    employees.id_sexo = leer.GetInt32(3);
                    employees.id_estado_civil = leer.GetInt32(4);
                    employees.fecha_nacimiento = leer.GetDateTime(5);
                    employees.edad = leer.GetInt32(6);
                    employees.fecha_contrato = leer.GetDateTime(7);
                    employees.telefono = leer.GetString(8);
                    employees.email = leer.GetString(9);
                    employees.direccion = leer.GetString(10);
                    employees.id_cargo = leer.GetInt32(11);
                    employees.salario = leer.GetDecimal(12);
                    employees.id_estado = leer.GetInt32(13);
                    resultado.Add(employees);
                }
                leer.Close();
                return resultado;
            }
        }
    }
}
