using System;

namespace RendimientosPorDescuento.ConObjetos
{
    public class RendimientoPorDescuento
    {
        public static double DeterminarRendimientoPorDescuento(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual, Boolean tratamientoFiscal)
        {
            return new RendimientoPorDescuentoRedondeado(valorFacial, valorTransadoNeto, tasaDeImpuesto,
             fechaDeVencimiento, fechaActual, tratamientoFiscal).ObtenerRendimientoPorDescuento();
        }
    }
}
