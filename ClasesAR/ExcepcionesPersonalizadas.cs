using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essenza.ClasesAR
{
    public class ExcepcionesPersonalizadas : Exception
    {
        private string RegistroNotValido {  get; set; }

        //Constructor sin parametros
        public ExcepcionesPersonalizadas() { }

        //Constructor con parametros
        public ExcepcionesPersonalizadas(string mensaje): base(mensaje) { }
        

        //Metodo de registros invalidos
        public static string RegistroInValido()
        {
            ExcepcionesPersonalizadas exp = new ExcepcionesPersonalizadas();
            exp.RegistroNotValido = "Intento de regisro no valido";
            return exp.RegistroNotValido;
        }

    }
}
