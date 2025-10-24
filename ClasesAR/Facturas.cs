using Essenza.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.ClasesAR
{
    public class Facturas
    {
        public int id_factura {  get; set; }
        public int id_cliente { get; set; }
        public DateTime fecha_venta {  get; set; }
        public int id_metodo_pago { get; set; }
        public decimal total_pagado { get; set; }

        //Fin del pago
        public static void PagoRealizado(Facturas facturas)
        {
            int resultado;
            string NewQuery = @"insert into facturas (id_cliente, fecha_venta, id_metodo_pago, total_pagado) 
                    values (@id_cliente, @fecha_venta, @id_metodo_pago, @total_pagado)";
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue(@"id_cliente", facturas.id_cliente);
                comando.Parameters.AddWithValue(@"fecha_venta", facturas.fecha_venta);
                comando.Parameters.AddWithValue(@"id_metodo_pago", facturas.id_metodo_pago);
                comando.Parameters.AddWithValue(@"total_pagado", facturas.total_pagado);
                resultado = comando.ExecuteNonQuery();
            }
        }

        //Obtener el id
        public static int IdFactura(Facturas facturas)
        {
            string NewQuery = @"select id_factura from facturas where
                    id_cliente = @id_cliente and 
                    fecha_venta = @fecha_venta and
                    id_metodo_pago = @id_metodo_pago and 
                    total_pagado = @total_pagado";

            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue(@"id_cliente", facturas.id_cliente);
                comando.Parameters.AddWithValue(@"fecha_venta", facturas.fecha_venta);
                comando.Parameters.AddWithValue(@"id_metodo_pago", facturas.id_metodo_pago);
                comando.Parameters.AddWithValue(@"total_pagado", facturas.total_pagado);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    facturas.id_factura = (int)reader["id_factura"];
                }
                reader.Close();
            }
            return facturas.id_factura;
        }

    }
}
