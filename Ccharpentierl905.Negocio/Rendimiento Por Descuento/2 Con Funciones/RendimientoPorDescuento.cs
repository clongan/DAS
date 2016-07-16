using System;

namespace RendimientosPorDescuento.ConFunciones
{
    public class RendimientoPorDescuento
    {
        public static double DeterminarRendimientoPorDescuento(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual, Boolean tratamientoFiscal)
        {
            double rendimientoPorDescuento = ObtenerRendimientoPorDescuentoSinRedondeo(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual, tratamientoFiscal);
            return RedondearConCuatroDecimales(rendimientoPorDescuento);
        }

        private static double ObtenerRendimientoPorDescuentoSinRedondeo(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual, bool tieneTratamientoFiscal)
        {
            if (tieneTratamientoFiscal)
                return AsignarRendimientoPorDescuentoSiTieneTratamientoFiscal(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual);
            else
                return AsignarRendimientoPorDescuentoSiNoTieneTratamientoFiscal(valorFacial, valorTransadoNeto);
        }

        private static double AsignarRendimientoPorDescuentoSiNoTieneTratamientoFiscal(double valorFacial, double valorTransadoNeto)
        {
            return valorFacial - valorTransadoNeto;
        }

        private static double AsignarRendimientoPorDescuentoSiTieneTratamientoFiscal(double valorFacial, double valorTransadoNeto, 
            double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            double valorTransadoBruto = ObtenerValorTransadoBruto(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual);
            return CalcularRendimientoPorDescuento(valorFacial, valorTransadoBruto);
        }

        private static double CalcularRendimientoPorDescuento(double valorFacial, double valorTransadoBruto)
        {
            return valorFacial - valorTransadoBruto;
        }

        private static double ObtenerValorTransadoBruto(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, 
            DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            double diasAlVencimiento = ObtenerDiasAlVencimiento(fechaDeVencimiento, fechaActual);
            double tasaBruta = ObtenerTasaBruta(valorFacial, valorTransadoNeto, tasaDeImpuesto, diasAlVencimiento);
            return CalcularValorTransadoBruto(valorFacial, diasAlVencimiento, tasaBruta);
        }

        private static double ObtenerDiasAlVencimiento(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            TimeSpan diasAlVencimiento = ObtengaLaDiferencia(fechaDeVencimiento, fechaActual);
            return ObtengaLosDiasTotales(diasAlVencimiento);
        }

        private static TimeSpan ObtengaLaDiferencia(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            return fechaDeVencimiento - fechaActual;
        }

        private static double ObtengaLosDiasTotales(TimeSpan diasAlVencimiento)
        {
            return diasAlVencimiento.TotalDays;
        }

        private static double CalcularValorTransadoBruto(double valorFacial, double diasAlVencimiento, double tasaBruta)
        {
            return valorFacial / (1 + ((tasaBruta / 100) * (diasAlVencimiento / 365)));
        }

        private static double ObtenerTasaBruta(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, double diasAlVencimiento)
        {
            double tasaNeta = ObtenerTasaNeta(valorFacial, valorTransadoNeto, diasAlVencimiento);
            return CalcularTasaBruta(tasaDeImpuesto, tasaNeta);
        }

        private static double CalcularTasaBruta(double tasaDeImpuesto, double tasaNeta)
        {
            return tasaNeta / (1 - tasaDeImpuesto);
        }

        private static double ObtenerTasaNeta(double valorFacial, double valorTransadoNeto, double diasAlVencimiento)
        {
            return ((valorFacial - valorTransadoNeto) / (valorTransadoNeto * (diasAlVencimiento / 365))) * 100;
        }

        private static double RedondearConCuatroDecimales(double rendimientoPorDescuento)
        {
            return Math.Round(rendimientoPorDescuento, 4);
        }
    }
}
