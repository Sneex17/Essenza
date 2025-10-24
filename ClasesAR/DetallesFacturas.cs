using DocumentFormat.OpenXml.Wordprocessing;
using Essenza.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.ClasesAR
{
    public class DetallesFacturas
    {
        public int id_factura {  get; set; }
        public int id_cliente { get; set; }
        public int id_empleado { get; set; }
        public int id_inventario { get; set; }

        public DateTime fecha_venta {  get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal precio_cantidad { get; set; }
        public decimal itbis {  get; set; }
        public decimal subtotal { get; set; }

        //Agregar el detalle de la factura en proceso
        public static void AddDetalleFactura(DetallesFacturas detallesFacturas)
        {
            int resultado;
            string NewQuery = @"Insert into detalle_factura (id_cliente, id_empleado, id_inventario, 
                fecha_venta, descripcion, cantidad, precio_unitario, precio_cantidad, itbis, subtotal) values 
                (@id_cliente, @id_empleado, @id_inventario, @fecha_venta, @descripcion, @cantidad, 
                @precio_unitario, @precio_cantidad, @itbis, @subtotal)";

            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue(@"id_cliente", detallesFacturas.id_cliente);
                comando.Parameters.AddWithValue(@"id_empleado", detallesFacturas.id_empleado);
                comando.Parameters.AddWithValue(@"id_inventario", detallesFacturas.id_inventario);
                comando.Parameters.AddWithValue(@"fecha_venta", detallesFacturas.fecha_venta);
                comando.Parameters.AddWithValue(@"descripcion", detallesFacturas.descripcion);
                comando.Parameters.AddWithValue(@"cantidad", detallesFacturas.cantidad);
                comando.Parameters.AddWithValue(@"precio_uitario", detallesFacturas.precio_unitario);
                comando.Parameters.AddWithValue(@"precio_cantidad", detallesFacturas.precio_cantidad);
                comando.Parameters.AddWithValue(@"itbis", detallesFacturas.itbis);
                comando.Parameters.AddWithValue(@"subtotal", detallesFacturas.subtotal);
                resultado = comando.ExecuteNonQuery();
            }

        }
        // Fin del pago
        public static void FinProcesoPago(DetallesFacturas detallesFacturas)
        {
            int resultado;
            string NewQuery = @"update detalle_factura set
                                id_factura = @id_factura
                                where id_cliente = @id_cliente";
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue(@"id_factura", detallesFacturas.id_factura);
                comando.Parameters.AddWithValue(@"id_cliente", detallesFacturas.id_cliente);
                resultado = comando.ExecuteNonQuery();
            }
        }

        //Pago Cancelado
        public static void PagoCancelado(DetallesFacturas detallesFacturas)
        {
            int resultado;
            string NewQuery = @"delete detalle_factura where id_cliente = @id_cliente";
            using (SqlConnection acceso = EssenzaSystemDB.EssenzaDB())
            {
                SqlCommand comando = new SqlCommand(NewQuery, acceso);
                comando.Parameters.AddWithValue(@"id_cliente", detallesFacturas.id_cliente);
                resultado = comando.ExecuteNonQuery();
            }
        }

    }
}
