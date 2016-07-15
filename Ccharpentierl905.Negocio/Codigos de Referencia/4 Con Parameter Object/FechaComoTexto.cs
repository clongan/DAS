using System;

namespace ConParameterObject
{
    public class FechaComoTexto
    {
        string dia;
        string mes;
        string año;

        public FechaComoTexto(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            dia = ObtenerDiaDeFechaCompleta(laInformacionDelCodigo);
            mes = ObtenerMesDeFechaCompleta(laInformacionDelCodigo);
            año = ObtenerAñoDeFechaCompleta(laInformacionDelCodigo);
        }

        private string ObtenerDiaDeFechaCompleta(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            return new Dia(laInformacionDelCodigo).ComoTexto();
        }

        private string ObtenerMesDeFechaCompleta(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            return new Mes(laInformacionDelCodigo).ComoTexto();
        }

        private string ObtenerAñoDeFechaCompleta(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            return new Año(laInformacionDelCodigo).ComoTexto();
        }

        public string ComoTexto()
        {
            return año + mes + dia;
        }
    }
}
