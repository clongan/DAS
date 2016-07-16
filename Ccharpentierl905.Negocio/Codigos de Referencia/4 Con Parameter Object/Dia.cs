namespace CodigosDeReferencia.ConParameterObject
{
    public class Dia
    {
        private int dia;

        public Dia(InformacionDelCodigoDeReferencia laInformacion)
        {
            dia = ObtenerDiaDeFechaCompleta(laInformacion);
        }

        public int ObtenerDiaDeFechaCompleta(InformacionDelCodigoDeReferencia laInformacion)
        {
            // TODO: 2 PUNTOS 
            return laInformacion.fecha.Day;
        }

        public string ComoTexto()
        {
            return new DiaComoTexto(dia).ComoTexto();
        }
    }
}
