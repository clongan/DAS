using RendimientosPorDescuento.ConParameterObject;

namespace Impuestos.ConParameterObject
{
    public class Impuesto
    {
        public static double DeterminarImpuesto(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            return new ImpuestoRedondeado(laInformacion).ObtenerRendimientoPorDescuento();
        }
    }
}
