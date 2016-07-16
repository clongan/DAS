using System;

namespace RendimientosPorDescuento.ConObjetos
{
    public class DiasAlVencimiento
    {
        private TimeSpan diasAlVencimiento;

        public DiasAlVencimiento(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            diasAlVencimiento = ObtenerDiasAlVencimiento(fechaDeVencimiento, fechaActual);
        }

        private TimeSpan ObtenerDiasAlVencimiento(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            return fechaDeVencimiento - fechaActual;
        }

        public double DiasTotales()
        {
            return diasAlVencimiento.TotalDays;
        }
    }
}
