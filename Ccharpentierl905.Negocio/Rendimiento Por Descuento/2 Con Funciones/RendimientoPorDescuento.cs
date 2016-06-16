using System;

namespace Ccharpentierl905.Negocio.ConFunciones.RendimientoPorDescuento
{
    public class RendimientoPorDescuento
    {
        public static decimal DeterminarRendimientoPorDescuento(decimal valorFacial, decimal valorTransadoNeto, decimal tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual, Boolean tratamientoFiscal)
        {
            decimal rendimientoPorDescuento = ObtenerRendimientoPorDescuento(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual, tratamientoFiscal);

            return RedondearRendimientoPorDescuento(rendimientoPorDescuento);
        }

        private static decimal ObtenerRendimientoPorDescuento(decimal valorFacial, decimal valorTransadoNeto, decimal tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual, bool tratamientoFiscal)
        {
            decimal rendimientoPorDescuento;

            if (TratamientoFiscalEsVerdadero(tratamientoFiscal))
            {
                rendimientoPorDescuento = EstablecerRendimientoPorDescuentoSiTratamientoFiscalEsVerdadero(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual);
            }
            else
            {
                rendimientoPorDescuento = EstablecerRendimientoPorDescuentoSiTratamientoFiscalEsFalso(valorFacial, valorTransadoNeto);
            }

            return rendimientoPorDescuento;
        }

        private static bool TratamientoFiscalEsVerdadero(bool tratamientoFiscal)
        {
            return tratamientoFiscal == true;
        }

        private static decimal EstablecerRendimientoPorDescuentoSiTratamientoFiscalEsVerdadero(decimal valorFacial, decimal valorTransadoNeto, decimal tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            decimal diasAlVencimiento = DeterminarDiasAlVencimiento(fechaDeVencimiento, fechaActual);
            decimal tasaBruta = DeterminarTasaBruta(valorFacial, valorTransadoNeto, tasaDeImpuesto, diasAlVencimiento);
            return RetornarRendimientoPorDescuentoSiTratamientoFiscalEsVerdadero(valorFacial, diasAlVencimiento, tasaBruta);
        }

        private static decimal DeterminarDiasAlVencimiento(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            double diasAlVencimiento = EstablecerDiasAlVencimiento(fechaDeVencimiento, fechaActual);
            return ConvertirDiasAlVencimientoADecimal(diasAlVencimiento);
        }

        private static double EstablecerDiasAlVencimiento(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            return (fechaDeVencimiento - fechaActual).TotalDays;
        }

        private static decimal ConvertirDiasAlVencimientoADecimal(double diasAlVencimiento)
        {
            return Convert.ToDecimal(diasAlVencimiento);
        }

        private static decimal DeterminarTasaBruta(decimal valorFacial, decimal valorTransadoNeto, decimal tasaDeImpuesto, decimal diasAlVencimiento)
        {
            decimal tasaNeta = AsignarTasaNeta(valorFacial, valorTransadoNeto, diasAlVencimiento);
            return ObtenerTasaBruta(tasaDeImpuesto, tasaNeta);
        }

        private static decimal AsignarTasaNeta(decimal valorFacial, decimal valorTransadoNeto, decimal diasAlVencimiento)
        {
            return ((valorFacial - valorTransadoNeto) / (valorTransadoNeto * (diasAlVencimiento / 365))) * 100;
        }

        private static decimal ObtenerTasaBruta(decimal tasaDeImpuesto, decimal tasaNeta)
        {
            return tasaNeta / (1 - tasaDeImpuesto);
        }

        private static decimal RetornarRendimientoPorDescuentoSiTratamientoFiscalEsVerdadero(decimal valorFacial, decimal diasAlVencimiento, decimal tasaBruta)
        {
            return valorFacial - (valorFacial / (1 + ((tasaBruta / 100) * (diasAlVencimiento / 365))));
        }

        private static decimal EstablecerRendimientoPorDescuentoSiTratamientoFiscalEsFalso(decimal valorFacial, decimal valorTransadoNeto)
        {
            return valorFacial - valorTransadoNeto;
        }

        private static decimal RedondearRendimientoPorDescuento(decimal rendimientoPorDescuento)
        {
            return decimal.Round(rendimientoPorDescuento, 4);
        }
    }
}
