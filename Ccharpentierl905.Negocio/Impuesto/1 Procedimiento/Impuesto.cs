using System;

namespace Impuestos.ComoUnProcedimiento
{
    public class Impuesto
    {
        public static double DeterminarImpuesto(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual, Boolean tieneTratamientoFiscal)
        {
            double impuesto = 0;

            if (tieneTratamientoFiscal)
            {
                double diasAlVencimiento = (fechaDeVencimiento-fechaActual).TotalDays;
                double tasaNeta = ((valorFacial - valorTransadoNeto) / (valorTransadoNeto * (diasAlVencimiento / 365))) * 100;
                double tasaBruta = tasaNeta / (1 - tasaDeImpuesto);
                double valorTransadoBruto = valorFacial / (1 + ((tasaBruta / 100) * (diasAlVencimiento / 365)));
                impuesto = valorTransadoNeto - valorTransadoBruto;

            }
            else
            {
                impuesto = 0;
            }
            return Math.Round(impuesto,4);
        }
    }
}
