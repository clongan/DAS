using System;

namespace ConObjetos
{
    public class Impuesto
    {
        public static double DeterminarImpuesto(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual, Boolean tieneTratamientoFiscal)
        {
            return new ImpuestoRedondeado(valorFacial, valorTransadoNeto, tasaDeImpuesto,
             fechaDeVencimiento, fechaActual, tieneTratamientoFiscal).ObtenerRendimientoPorDescuento();
        }
    }
}
