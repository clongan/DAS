namespace CodigosDeReferencia.ConParameterObject
{
    public class FechaComoTexto
    {
        string dia;
        string mes;
        string año;

        public FechaComoTexto(InformacionDelCodigoDeReferencia laInformacion)
        {
            dia = ObtenerDiaDeFechaCompleta(laInformacion);
            mes = ObtenerMesDeFechaCompleta(laInformacion);
            año = ObtenerAñoDeFechaCompleta(laInformacion);
        }

        private string ObtenerDiaDeFechaCompleta(InformacionDelCodigoDeReferencia laInformacion)
        {
            return new Dia(laInformacion).ComoTexto();
        }

        private string ObtenerMesDeFechaCompleta(InformacionDelCodigoDeReferencia laInformacion)
        {
            return new Mes(laInformacion).ComoTexto();
        }

        private string ObtenerAñoDeFechaCompleta(InformacionDelCodigoDeReferencia laInformacion)
        {
            return new Año(laInformacion).ComoTexto();
        }

        public string ComoTexto()
        {
            return año + mes + dia;
        }
    }
}
