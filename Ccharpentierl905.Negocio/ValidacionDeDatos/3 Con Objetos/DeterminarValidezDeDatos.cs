using System;

namespace ValidacionDeDatos.ConObjetos
{
    public class DeterminarValidezDeDatos
    {
        private bool elValorFacialEsValido;
        private bool elValorTransadoNetoEsValido;
        private bool laTasaDeImpuestoEsMayorACero;
        private bool laTasaDeImpuestoEsMenorAUno;
        private bool laFechaActualEsMenorAFechaDeVencimiento;

        public DeterminarValidezDeDatos(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            elValorFacialEsValido = DeterminarElValorFacial(valorFacial);
            elValorTransadoNetoEsValido = DeterminarElValorTransadoNeto(valorTransadoNeto);
            laTasaDeImpuestoEsMayorACero = DeterminarLaTasaDeImpuestoMayorACero(tasaDeImpuesto);
            laTasaDeImpuestoEsMenorAUno = DeterminarLaTasaDeImpuestoMenorAUno(tasaDeImpuesto);
            laFechaActualEsMenorAFechaDeVencimiento = DeterminarSiLaFechaActualEsMenorAFechaDeVencimiento(fechaDeVencimiento, fechaActual);
        }

        public bool DeterminarSiEsValido()
        {
            if (elValorFacialEsValido && elValorTransadoNetoEsValido && laTasaDeImpuestoEsMayorACero &&
                            laTasaDeImpuestoEsMenorAUno && laFechaActualEsMenorAFechaDeVencimiento)
                return true;
            else
                return false;
        }

        private bool DeterminarSiLaFechaActualEsMenorAFechaDeVencimiento(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            return (fechaActual < fechaDeVencimiento);
        }

        private bool DeterminarLaTasaDeImpuestoMenorAUno(double tasaDeImpuesto)
        {
            return (tasaDeImpuesto < 1);
        }

        private bool DeterminarLaTasaDeImpuestoMayorACero(double tasaDeImpuesto)
        {
            return (tasaDeImpuesto > 0);
        }

        private bool DeterminarElValorTransadoNeto(double valorTransadoNeto)
        {
            return (valorTransadoNeto > 100000);
        }

        private bool DeterminarElValorFacial(double valorFacial)
        {
            return (valorFacial > 100000);
        }
    }
}
