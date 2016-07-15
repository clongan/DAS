using System;

namespace ConParameterObject
{
    public class Mes
    {
        private int mes;

        public Mes(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            mes = ObtenerMesDeFechaCompleta(laInformacionDelCodigo);
        }

        private int ObtenerMesDeFechaCompleta(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            // TODO: 2 PUNTOS
            return laInformacionDelCodigo.fecha.Month;
        }

        public string ComoTexto()
        {
            return mes.ToString().PadLeft(2, '0');
        }
    }
}
