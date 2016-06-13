using System;
using Ccharpentierl905.Negocio.ComoUnProcedimiento.Calculos;

namespace Ccharpentierl905.Negocio.ComoUnProcedimiento.RendimientoPorDescuento
{
    public class RendimientoPorDescuento
    {
        public static decimal DeterminarRendimientoPorDescuento(decimal valorFacial, decimal valorTransadoNeto, decimal tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual, Boolean tratamientoFiscal)
        {
            decimal rendimientoPorDescuento = 0;
            decimal valorTransadoBruto = 0;

            if (tratamientoFiscal == true)
            {
                decimal diasAlVencimiento = Convert.ToDecimal((fechaDeVencimiento - fechaActual).TotalDays);
                decimal tasaNeta = ((valorFacial - valorTransadoNeto) / (valorTransadoNeto * (diasAlVencimiento / 365))) * 100;
                decimal tasaBruta = tasaNeta / (1 - tasaDeImpuesto);
                valorTransadoBruto = valorFacial / (1 + ((tasaBruta / 100) * (diasAlVencimiento / 365)));
                rendimientoPorDescuento = valorFacial - valorTransadoBruto;

            }
            else
            {
                valorTransadoBruto = valorTransadoNeto;
                rendimientoPorDescuento = valorFacial - valorTransadoBruto;
            }

            return decimal.Round(rendimientoPorDescuento, 4);
        }
    }
}
