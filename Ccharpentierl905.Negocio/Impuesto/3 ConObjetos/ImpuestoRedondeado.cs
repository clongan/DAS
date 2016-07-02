using System;

namespace ConObjetos
{
    public class ImpuestoRedondeado
    {
        private double impuesto;

        public ImpuestoRedondeado(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual, bool tieneTratamientoFiscal)
        {
            impuesto = ObtenerImpuestoSinRedondeo(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual, tieneTratamientoFiscal);
        }

        private double ObtenerImpuestoSinRedondeo(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual, bool tieneTratamientoFiscal)
        {
            if (tieneTratamientoFiscal)
                return new ImpuestoConTratamientoFiscal(valorFacial, valorTransadoNeto,
            tasaDeImpuesto, fechaDeVencimiento, fechaActual).CalcularImpuesto();
            else
                return 0;
        }

        public double ObtenerRendimientoPorDescuento()
        {
            return Math.Round(impuesto, 4);
        }
    }
}
