using System;
using System.Collections.Generic;
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
    }
}
