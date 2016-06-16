using System;

namespace Ccharpentierl905.Negocio.ConFunciones.RendimientoPorDescuento
{
    public class RendimientoPorDescuento
    {
        public static double DeterminarRendimientoPorDescuento(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual, Boolean tratamientoFiscal)
        {
            double rendimientoPorDescuento = ObtenerRendimientoPorDescuento(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual, tratamientoFiscal);
            return RedondearConCuatroDecimales(rendimientoPorDescuento);
        }

        private static double ObtenerRendimientoPorDescuento(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual, bool tratamientoFiscal)
        {
            double rendimientoPorDescuento = 0;

            if (tratamientoFiscal == true)
            {
                rendimientoPorDescuento = EstablecerRendimientoPorDescuentoSiTratamientoFiscalEsVerdadero(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual);
            }
            else
            {
                rendimientoPorDescuento = EstablecerRendimientoPorDescuentoSiTratamientoFiscalEsFalso(valorFacial, valorTransadoNeto);
            }
      
            return rendimientoPorDescuento;
        }

        private static double EstablecerRendimientoPorDescuentoSiTratamientoFiscalEsVerdadero(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            double valorTransadoBruto = ObtenerValorTransadoBruto(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual);
            return valorFacial - valorTransadoBruto;
        }

        private static double ObtenerValorTransadoBruto(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            double diasAlVencimiento = ObtenerDiasAlVencimiento(fechaDeVencimiento, fechaActual);
            double tasaBruta = ObtenerTasaBruta(valorFacial, valorTransadoNeto, tasaDeImpuesto, diasAlVencimiento);
            return DeterminarValorTransadoBruto(valorFacial, diasAlVencimiento, tasaBruta);
        }

        private static double ObtenerDiasAlVencimiento(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            TimeSpan diasAlVencimiento = DeterminarDiasAlVencimiento(fechaDeVencimiento, fechaActual);
            return ConvertirDiasAlVencimientoAEntero(diasAlVencimiento);
        }

        private static TimeSpan DeterminarDiasAlVencimiento(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            return fechaDeVencimiento - fechaActual;
        }

        private static double ConvertirDiasAlVencimientoAEntero(TimeSpan diasAlVencimiento)
        {
            return diasAlVencimiento.TotalDays;
        }

        private static double DeterminarValorTransadoBruto(double valorFacial, double diasAlVencimiento, double tasaBruta)
        {
            return valorFacial / (1 + ((tasaBruta / 100) * (diasAlVencimiento / 365)));
        }

        private static double ObtenerTasaBruta(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, double diasAlVencimiento)
        {
            double tasaNeta = ObtenerTasaNeta(valorFacial, valorTransadoNeto, diasAlVencimiento);
            return tasaNeta / (1 - tasaDeImpuesto);
        }

        private static double ObtenerTasaNeta(double valorFacial, double valorTransadoNeto, double diasAlVencimiento)
        {
            return ((valorFacial - valorTransadoNeto) / (valorTransadoNeto * (diasAlVencimiento / 365))) * 100;
        }

        private static double EstablecerRendimientoPorDescuentoSiTratamientoFiscalEsFalso(double valorFacial, double valorTransadoNeto)
        {
            return valorFacial - valorTransadoNeto;
        }

        private static double RedondearConCuatroDecimales(double rendimientoPorDescuento)
        {
            return Math.Round(rendimientoPorDescuento, 4);
        }
    }
}
