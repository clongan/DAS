using System;

namespace CodigosDeReferencia.ConObjetos
{
    public class Año
    {
        private int año;

        public Año(DateTime fecha)
        {
            año = ObtenerAñoDeFechaCompleta(fecha);
        }

        private int ObtenerAñoDeFechaCompleta(DateTime fecha)
        {
            return fecha.Year;
        }

        public string ComoTexto()
        {
            return año.ToString();
        }
    }
}
