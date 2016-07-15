using System;

namespace ConParameterObject
{
    public class Año
    {
        private int año;

        public Año(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            año = ObtenerAñoDeFechaCompleta(laInformacionDelCodigo);
        }

        private int ObtenerAñoDeFechaCompleta(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            // TODO: 2 PUNTOS
            return laInformacionDelCodigo.fecha.Year;
        }

        public string ComoTexto()
        {
            return año.ToString();
        }
    }
}
