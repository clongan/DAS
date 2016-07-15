using System;

namespace ConParameterObject
{
    public class Dia
    {
        private int dia;

        public Dia(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            dia = ObtenerDiaDeFechaCompleta(laInformacionDelCodigo);
        }

        public int ObtenerDiaDeFechaCompleta(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            // TODO: 2 PUNTOS
            return laInformacionDelCodigo.fecha.Day;
        }

        public string ComoTexto()
        {
            return dia.ToString().PadLeft(2, '0');
        }

    }
}
