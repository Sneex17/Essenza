using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.ClasesAR
{
    public class Imprimir
    {

        public static void ImprimirFacturaPDF(List<DetallesFacturas> lista, PrintPageEventArgs l, int idpago, int idfact)
        {
            List<DetallesFacturas> products = new List<DetallesFacturas>();
            products = lista;

            Font f = new Font("Times New Roman", 8);
            Font j = new Font("Times New Roman", 7);
            int ancho = 400;
            int y = 50;
            int x = 50;


            l.Graphics.DrawString("                                ESSENZA SRL                                ", f, Brushes.Black,
                new RectangleF(x, y += 17, ancho, 20));
            l.Graphics.DrawString("                            República Dminicana                            ", f, Brushes.Black,
                new RectangleF(x, y += 17, ancho, 20));
            l.Graphics.DrawString("                               RNC: 123456789                              ", f, Brushes.Black,
                new RectangleF(x, y += 17, ancho, 20));

            l.Graphics.DrawLine(Pens.Black, x, y += 17, ancho, y);
            l.Graphics.DrawString($"Fecha:           {DateTime.Now}                                           ", f, Brushes.Black,
                new RectangleF(x, y += 17, ancho, 20));
            l.Graphics.DrawLine(Pens.Black, x, y += 17, ancho, y);

            l.Graphics.DrawString("                        FACTURA DE PAGO ELECTRÓNICO                        ", f, Brushes.Black,
                new RectangleF(x, y += 17, ancho, 20));
            l.Graphics.DrawString("-------------------------------- DATOS GENERALES --------------------------------", f, Brushes.Black,
                new RectangleF(x, y += 20, ancho, 20));

            int IDfactura = idfact, IDcliente = 0, IDempleado = 0;
            foreach (var t in lista)
            { 
                IDcliente = t.id_cliente;
                IDempleado = t.id_empleado;
            }

            
            string metodoDePago;
            if(idpago == 1)
            {
                metodoDePago = "Efectivo";
            }
            else
            {
                metodoDePago = "Transferencia Bancaria";
            }

            l.Graphics.DrawString($"ID FACTURA: {IDfactura}", f, Brushes.Black,
                new RectangleF(x, y += 20, ancho, 20));
            l.Graphics.DrawString($"ID CLIENTE: {IDcliente}", f, Brushes.Black,
                new RectangleF(x, y += 20, ancho, 20));
            l.Graphics.DrawString($"ID EMPLEADO: {IDempleado}", f, Brushes.Black,
                new RectangleF(x, y += 20, ancho, 20));
            l.Graphics.DrawString($"METODO DE PAGO: {metodoDePago}", f, Brushes.Black,
                new RectangleF(x, y += 20, ancho, 20));






            l.Graphics.DrawString("-------------------------------------------- PRODUCTOS --------------------------------------------", j, Brushes.Black,
                new RectangleF(x, y += 20, ancho, 20));
            l.Graphics.DrawString("| ID PRODUCTO  | CANTIDAD  | PRECIO UNITARIO  | ITBIS         | SUBTOTAL  |", j, Brushes.Black,
                new RectangleF(x, y += 20, ancho += 100, 20));

            decimal subtotal = 0;
            decimal impuesto = 0;
            y = y + 17;
            foreach (var i in products)
            {

                l.Graphics.DrawString($"| {i.id_inventario}",
                    j, Brushes.Black, new RectangleF(50, y, ancho, 20));
                l.Graphics.DrawString($"| {i.cantidad}",
                    j, Brushes.Black, new RectangleF(129, y, ancho, 20));
                l.Graphics.DrawString($"| ${i.precio_unitario}",
                    j, Brushes.Black, new RectangleF(189, y, ancho, 20));
                l.Graphics.DrawString($"| ${i.itbis}",
                    j, Brushes.Black, new RectangleF(285, y, ancho, 20));
                l.Graphics.DrawString($"| ${i.subtotal}",
                     j, Brushes.Black, new RectangleF(338, y, ancho, 20));
                y += 17;

                subtotal += (i.cantidad * i.precio_unitario);
                impuesto += i.itbis;

            }
            l.Graphics.DrawLine(Pens.Black, x, y += 17, ancho - 100, y);
            l.Graphics.DrawString($"Numero de articulos vendidos: {products.Count}", f, Brushes.Black,
                new RectangleF(130, y += 17, ancho, 20));
            l.Graphics.DrawString($"IMPUESTO: ${impuesto}", f, Brushes.Black,
                new RectangleF(130, y += 17, ancho, 20));
            l.Graphics.DrawString($"SUBTOTAL: ${subtotal}", f, Brushes.Black,
                new RectangleF(130, y += 17, ancho, 20));
            l.Graphics.DrawString($"TOTAL: ${subtotal + impuesto}", f, Brushes.Black,
                new RectangleF(130, y += 17, ancho, 20));
        }
    }
}
