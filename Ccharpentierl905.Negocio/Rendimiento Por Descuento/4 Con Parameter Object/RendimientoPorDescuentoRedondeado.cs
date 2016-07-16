using System;

namespace RendimientosPorDescuento.ConParameterObject
{
    public class RendimientoPorDescuentoRedondeado
    {
        private double rendimientoPorDescuento;

        public RendimientoPorDescuentoRedondeado(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            rendimientoPorDescuento = ObtenerRendimientoPorDescuentoSinRedondeo(laInformacion);
        }

        private double ObtenerRendimientoPorDescuentoSinRedondeo(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            if (laInformacion.tieneTratamientoFiscal)
                return new RendimientoPorDescuentoConTratamientoFiscal(laInformacion).CalcularRendimientoPorDescuento();
            else
                return ObtenerRendimientoPorDescuentoSinTratamientoFiscal(laInformacion);
        }

        private static double ObtenerRendimientoPorDescuentoSinTratamientoFiscal(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            return laInformacion.valorFacial - laInformacion.valorTransadoNeto;
        }

        public double ObtenerRendimientoPorDescuento()
        {
            return Math.Round(rendimientoPorDescuento, 4);
        }
    }
}
