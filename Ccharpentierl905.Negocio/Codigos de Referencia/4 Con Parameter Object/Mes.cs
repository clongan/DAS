using System;

namespace ConParameterObject
{
    public class Mes
    {
        private int mes;

        public Mes(DateTime fecha)
        {
            mes = ObtenerMesDeFechaCompleta(fecha);
        }

        private int ObtenerMesDeFechaCompleta(DateTime fecha)
        {
            return fecha.Month;
        }

        public string ComoTexto()
        {
            return mes.ToString().PadLeft(2, '0');
        }
    }
}
