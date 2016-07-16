using System;

namespace CodigosDeReferencia.ConParameterObject
{
    public class Año
    {
        private int año;

        public Año(InformacionDelCodigoDeReferencia laInformacion)
        {
            año = ObtenerAñoDeFechaCompleta(laInformacion);
        }

        private int ObtenerAñoDeFechaCompleta(InformacionDelCodigoDeReferencia laInformacion)
        {
            // TODO: 2 PUNTOS
            return laInformacion.fecha.Year;
        }

        public string ComoTexto()
        {
            return año.ToString();
        }
    }
}
