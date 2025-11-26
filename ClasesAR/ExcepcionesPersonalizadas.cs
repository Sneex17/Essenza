using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.ClasesAR
{
    public class ExcepcionesPersonalizadas : Exception
    {
        private string RegistroNotValido = "Intento de regisro no valido";

        public ExcepcionesPersonalizadas()
        {

        }
        public ExcepcionesPersonalizadas(string mensaje): base(mensaje) { }

        public static string RegistroInValido()
        {
            ExcepcionesPersonalizadas exp = new ExcepcionesPersonalizadas();
            return exp.RegistroNotValido;
        }

    }
}
