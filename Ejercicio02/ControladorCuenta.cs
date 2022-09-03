using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public static class ControladorCuenta
    {
        public static Cuenta CrearCuentaEnPesos()
        {
            Moneda moneda = new Moneda("SRA", "Peso argentino", "ARS");
            Cuenta cuenta = new Cuenta(0.0, moneda);
            return cuenta;
        }

        public static Cuenta CrearCuentaEnDolares()
        {
            Moneda moneda = new Moneda("USD", "Dólar estadounidense", "USD");
            Cuenta cuenta = new Cuenta(0.0, moneda);
            return cuenta;
        }
    }
}
