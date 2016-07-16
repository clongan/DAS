using System;

namespace RendimientosPorDescuento.ConParameterObject
{
    public class RendimientoPorDescuento
    {
        public static double DeterminarRendimientoPorDescuento(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            return new RendimientoPorDescuentoRedondeado(laInformacion).ObtenerRendimientoPorDescuento();
        }
    }
}
