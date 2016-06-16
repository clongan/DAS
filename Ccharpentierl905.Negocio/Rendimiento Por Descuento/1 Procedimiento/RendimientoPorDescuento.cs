using System;

namespace Ccharpentierl905.Negocio.ComoUnProcedimiento.RendimientoPorDescuento
{
    public class RendimientoPorDescuento
    {
        public static double DeterminarRendimientoPorDescuento(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual, Boolean tratamientoFiscal)
        {
            double rendimientoPorDescuento = 0;

            if (tratamientoFiscal == true)
            {
                double diasAlVencimiento = (fechaDeVencimiento - fechaActual).TotalDays;
                double tasaNeta = ((valorFacial - valorTransadoNeto) / (valorTransadoNeto * (diasAlVencimiento / 365))) * 100;
                double tasaBruta = tasaNeta / (1 - tasaDeImpuesto);
                double valorTransadoBruto = valorFacial / (1 + ((tasaBruta / 100) * (diasAlVencimiento / 365)));
                rendimientoPorDescuento = valorFacial - valorTransadoBruto;
            }
            else
            {
                rendimientoPorDescuento = valorFacial - valorTransadoNeto;
            }
            return Math.Round(rendimientoPorDescuento,4);
        }
    }
}
