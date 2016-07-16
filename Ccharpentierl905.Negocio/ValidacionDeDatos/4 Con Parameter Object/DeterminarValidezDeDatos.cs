using System;

namespace ValidacionDeDatos.ConParameterObject
{
    public class DeterminarValidezDeDatos
    {
        private bool elValorFacialEsValido;
        private bool elValorTransadoNetoEsValido;
        private bool laTasaDeImpuestoEsMayorACero;
        private bool laTasaDeImpuestoEsMenorAUno;
        private bool laFechaActualEsMenorAFechaDeVencimiento;

        public DeterminarValidezDeDatos(LaInformacionDeValidacion laInformacion)
        {
            elValorFacialEsValido = DeterminarElValorFacial(laInformacion.valorFacial);
            elValorTransadoNetoEsValido = DeterminarElValorTransadoNeto(laInformacion.valorTransadoNeto);
            laTasaDeImpuestoEsMayorACero = DeterminarLaTasaDeImpuestoMayorACero(laInformacion.tasaDeImpuesto);
            laTasaDeImpuestoEsMenorAUno = DeterminarLaTasaDeImpuestoMenorAUno(laInformacion.tasaDeImpuesto);
            laFechaActualEsMenorAFechaDeVencimiento = DeterminarSiLaFechaActualEsMenorAFechaDeVencimiento(laInformacion.fechaDeVencimiento, laInformacion.fechaActual);
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
