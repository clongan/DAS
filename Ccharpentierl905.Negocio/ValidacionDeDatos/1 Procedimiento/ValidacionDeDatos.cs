using System;

namespace ValidacionDeDatos.ComoUnProcedimiento
{
    public class ValidacionDeDato
    {
        public static bool ValidarDatos(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual)
        {

            bool elValorFacialEsValido = (valorFacial > 100000);
            bool elValorTransadoNetoEsValido = (valorTransadoNeto > 100000);
            bool laTasaDeImpuestoEsMayorACero = (tasaDeImpuesto > 0);
            bool laTasaDeImpuestoEsMenorAUno = (tasaDeImpuesto < 1);
            bool laFechaActualEsMenorAFechaDeVencimiento = (fechaActual < fechaDeVencimiento);

            bool esValido;

            if (elValorFacialEsValido && elValorTransadoNetoEsValido && laTasaDeImpuestoEsMayorACero &&
                laTasaDeImpuestoEsMenorAUno && laFechaActualEsMenorAFechaDeVencimiento)
                esValido = true;
            else
                esValido = false;

            return esValido;
        }
    }
}
