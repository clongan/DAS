using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConObjetos
{
    public class RendimientoPorDescuentoRedondeado
    {
        private double rendimientoPorDescuento;

        public RendimientoPorDescuentoRedondeado(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual, bool tieneTratamientoFiscal)
        {
            rendimientoPorDescuento = ObtenerRendimientoPorDescuentoSinRedondeo(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual, tieneTratamientoFiscal);
        }

        private double ObtenerRendimientoPorDescuentoSinRedondeo(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual, bool tieneTratamientoFiscal)
        {
            if (tieneTratamientoFiscal)
                return new RendimientoPorDescuentoConTratamientoFiscal(valorFacial, valorTransadoNeto,
            tasaDeImpuesto, fechaDeVencimiento, fechaActual).CalcularRendimientoPorDescuento();
            else
                return valorFacial - valorTransadoNeto;
        }

        public double ObtenerRendimientoPorDescuento()
        {
            return Math.Round(rendimientoPorDescuento, 4);
        }
    }
}
