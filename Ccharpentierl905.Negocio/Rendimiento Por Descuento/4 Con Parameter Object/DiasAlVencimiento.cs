using System;

namespace RendimientosPorDescuento.ConParameterObject
{
    public class DiasAlVencimiento
    {
        private TimeSpan diasAlVencimiento;

        public DiasAlVencimiento(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            diasAlVencimiento = ObtenerDiasAlVencimiento(laInformacion);
        }

        private TimeSpan ObtenerDiasAlVencimiento(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            // TODO: REVISAR
            return laInformacion.fechaDeVencimiento - laInformacion.fechaActual;
        }

        public double DiasTotales()
        {
            return diasAlVencimiento.TotalDays;
        }
    }
}
