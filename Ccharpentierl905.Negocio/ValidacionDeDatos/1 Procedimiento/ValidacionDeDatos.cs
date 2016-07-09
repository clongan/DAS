using System;

namespace ComoUnProcedimiento
{
    public class ValidacionDeDatos
    {
        public static bool ValidarDatos(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            //sacar operaciones a valores aparte para que se lea "If elValorFacialEsValidado y ElValorTransado...etc
            if ((valorFacial > 100000) &&
                (valorTransadoNeto > 100000) &&
                (tasaDeImpuesto > 0) && (tasaDeImpuesto < 1) &&
                fechaActual < fechaDeVencimiento)
                return true;
            else
                return false;
        }
    }
}
