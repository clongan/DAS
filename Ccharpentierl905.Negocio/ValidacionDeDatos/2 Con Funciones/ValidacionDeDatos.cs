using System;

namespace ValidacionDeDatos.ConFunciones
{
    public class ValidacionDeDato
    {
        public static bool ValidarDatos(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            bool elValorFacialEsValido = DeterminarElValorFacial(valorFacial);
            bool elValorTransadoNetoEsValido = DeterminarElValorTransadoNeto(valorTransadoNeto);
            bool laTasaDeImpuestoEsMayorACero = DeterminarLaTasaDeImpuestoMayorACero(tasaDeImpuesto);
            bool laTasaDeImpuestoEsMenorAUno = DeterminarLaTasaDeImpuestoMenorAUno(tasaDeImpuesto);
            bool laFechaActualEsMenorAFechaDeVencimiento = DeterminarSiLaFechaActualEsMenorAFechaDeVencimiento(fechaDeVencimiento, fechaActual);

            return DeterminarSiEsValido(elValorFacialEsValido, elValorTransadoNetoEsValido,
                laTasaDeImpuestoEsMayorACero, laTasaDeImpuestoEsMenorAUno, laFechaActualEsMenorAFechaDeVencimiento);
        }

        private static bool DeterminarSiLaFechaActualEsMenorAFechaDeVencimiento(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            return (fechaActual < fechaDeVencimiento);
        }

        private static bool DeterminarLaTasaDeImpuestoMenorAUno(double tasaDeImpuesto)
        {
            return (tasaDeImpuesto < 1);
        }

        private static bool DeterminarLaTasaDeImpuestoMayorACero(double tasaDeImpuesto)
        {
            return (tasaDeImpuesto > 0);
        }

        private static bool DeterminarElValorTransadoNeto(double valorTransadoNeto)
        {
            return (valorTransadoNeto > 100000);
        }

        private static bool DeterminarElValorFacial(double valorFacial)
        {
            return (valorFacial > 100000);
        }

        private static bool DeterminarSiEsValido(bool elValorFacialEsValido, bool elValorTransadoNetoEsValido, bool laTasaDeImpuestoEsMayorACero, bool laTasaDeImpuestoEsMenorAUno, bool laFechaActualEsMenorAFechaDeVencimiento)
        {
            if (elValorFacialEsValido && elValorTransadoNetoEsValido && laTasaDeImpuestoEsMayorACero &&
                            laTasaDeImpuestoEsMenorAUno && laFechaActualEsMenorAFechaDeVencimiento)
                return true;
            else
                return false;
        }
    }
}
