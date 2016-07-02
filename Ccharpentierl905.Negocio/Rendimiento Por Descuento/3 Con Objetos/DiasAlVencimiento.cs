using System;

namespace ConObjetos
{
    public class DiasAlVencimiento
    {
        private TimeSpan diasAlVencimiento;

        public DiasAlVencimiento(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            diasAlVencimiento = fechaDeVencimiento - fechaActual;
        }

        public double DiasTotales()
        {
            return diasAlVencimiento.TotalDays;
        }
    }
}
