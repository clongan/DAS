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
            elValorFacialEsValido = DeterminarElValorFacial(laInformacion);
            elValorTransadoNetoEsValido = DeterminarElValorTransadoNeto(laInformacion);
            laTasaDeImpuestoEsMayorACero = DeterminarLaTasaDeImpuestoMayorACero(laInformacion);
            laTasaDeImpuestoEsMenorAUno = DeterminarLaTasaDeImpuestoMenorAUno(laInformacion);
            laFechaActualEsMenorAFechaDeVencimiento = DeterminarSiLaFechaActualEsMenorAFechaDeVencimiento(laInformacion);
        }

        public bool DeterminarSiEsValido()
        {
            if (elValorFacialEsValido && elValorTransadoNetoEsValido && laTasaDeImpuestoEsMayorACero &&
                            laTasaDeImpuestoEsMenorAUno && laFechaActualEsMenorAFechaDeVencimiento)
                return true;
            else
                return false;
        }

        private bool DeterminarSiLaFechaActualEsMenorAFechaDeVencimiento(LaInformacionDeValidacion laInformacion)
        {
            return (laInformacion.fechaActual < laInformacion.fechaDeVencimiento);
        }

        private bool DeterminarLaTasaDeImpuestoMenorAUno(LaInformacionDeValidacion laInformacion)
        {
            return (laInformacion.tasaDeImpuesto < 1);
        }

        private bool DeterminarLaTasaDeImpuestoMayorACero(LaInformacionDeValidacion laInformacion)
        {
            return (laInformacion.tasaDeImpuesto > 0);
        }

        private bool DeterminarElValorTransadoNeto(LaInformacionDeValidacion laInformacion)
        {
            return (laInformacion.valorTransadoNeto > 100000);
        }

        private bool DeterminarElValorFacial(LaInformacionDeValidacion laInformacion)
        {
            return (laInformacion.valorFacial > 100000);
        }
    }
}
