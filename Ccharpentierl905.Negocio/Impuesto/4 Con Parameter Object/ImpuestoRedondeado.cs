using System;
using RendimientosPorDescuento.ConParameterObject;

namespace Impuestos.ConParameterObject
{
    public class ImpuestoRedondeado
    {
        private double impuesto;

        public ImpuestoRedondeado(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            impuesto = ObtenerImpuestoSinRedondeo(laInformacion);
        }

        private double ObtenerImpuestoSinRedondeo(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            // TODO: 2 PUNTOS
            if (laInformacion.tieneTratamientoFiscal)
                return new ImpuestoConTratamientoFiscal(laInformacion).CalcularImpuesto();
            else
                return 0;
        }

        public double ObtenerRendimientoPorDescuento()
        {
            return Math.Round(impuesto, 4);
        }
    }
}
