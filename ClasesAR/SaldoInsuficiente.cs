using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.ClasesAR
{
    public class SaldoInsuficiente : Exception
    {
        public SaldoInsuficiente(string Mensaje):base(Mensaje) { }
    }
}
