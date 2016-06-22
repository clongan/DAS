using System;

namespace Ccharpentierl905.Negocio.ConFunciones.Impuesto
{
    public class Impuesto
    {
        public static double DeterminarImpuesto(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual, Boolean tieneTratamientoFiscal)
        {
            double impuesto = GenerarImpuesto(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual, tieneTratamientoFiscal);
            return RedondearImpuesto(impuesto);
        }

        private static double GenerarImpuesto(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual, bool tieneTratamientoFiscal)
        {
            if (tieneTratamientoFiscal)   
                return ObtenerImpuestoSiTieneTratamientoFiscal(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual);
            else
                return 0;
        }

        private static double ObtenerImpuestoSiTieneTratamientoFiscal(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            double diasAlVencimiento = CalcularDiasAlVencimiento(fechaDeVencimiento, fechaActual);
            double tasaBruta = CalcularTasaBruta(valorFacial, valorTransadoNeto, tasaDeImpuesto, diasAlVencimiento);
            return CalcularImpuesto(valorFacial, valorTransadoNeto, diasAlVencimiento, tasaBruta);
        }

        private static double CalcularDiasAlVencimiento(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            TimeSpan diferenciaDeDias = ObtengaDiferenciaDeDias(fechaDeVencimiento, fechaActual);
            return ObtengaLosDiasTotales(diferenciaDeDias);
        }

        private static double ObtengaLosDiasTotales(TimeSpan diferenciaDeDias)
        {
            return (diferenciaDeDias).TotalDays;
        }

        private static TimeSpan ObtengaDiferenciaDeDias(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            return fechaDeVencimiento - fechaActual;
        }

        private static double CalcularTasaBruta(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, double diasAlVencimiento)
        {
            double tasaNeta = CalcularTasaNeta(valorFacial, valorTransadoNeto, diasAlVencimiento);
            return ObtenerTasaBruta(tasaDeImpuesto, tasaNeta);
        }

        private static double CalcularTasaNeta(double valorFacial, double valorTransadoNeto, double diasAlVencimiento)
        {
            return ((valorFacial - valorTransadoNeto) / (valorTransadoNeto * (diasAlVencimiento / 365))) * 100;
        }

        private static double ObtenerTasaBruta(double tasaDeImpuesto, double tasaNeta)
        {
            return tasaNeta / (1 - tasaDeImpuesto);
        }

        private static double CalcularImpuesto(double valorFacial, double valorTransadoNeto, double diasAlVencimiento, double tasaBruta)
        {
            double valorTransadoBruto = CalcularValorTransadoBruto(valorFacial, diasAlVencimiento, tasaBruta);
            return DeterminarImpuesto(valorTransadoNeto, valorTransadoBruto);
        }

        private static double CalcularValorTransadoBruto(double valorFacial, double diasAlVencimiento, double tasaBruta)
        {
            return valorFacial / (1 + ((tasaBruta / 100) * (diasAlVencimiento / 365)));
        }

        private static double DeterminarImpuesto(double valorTransadoNeto, double valorTransadoBruto)
        {
            return valorTransadoNeto - valorTransadoBruto;
        }

        private static double RedondearImpuesto(double impuesto)
        {
            return Math.Round(impuesto, 4);
        }
    }
}
