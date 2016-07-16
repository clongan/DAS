using System;

namespace RendimientosPorDescuento.ComoUnProcedimiento
{
    public class RendimientoPorDescuento
    {
        public static double DeterminarRendimientoPorDescuento(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual, Boolean tieneTratamientoFiscal)
        {
            double rendimientoPorDescuento = 0;

            if (tieneTratamientoFiscal)
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
