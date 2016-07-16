namespace CodigosDeReferencia.ConParameterObject
{
    public class Mes
    {
        private int mes;

        public Mes(InformacionDelCodigoDeReferencia laInformacion)
        {
            mes = ObtenerMesDeFechaCompleta(laInformacion);
        }

        public int ObtenerMesDeFechaCompleta(InformacionDelCodigoDeReferencia laInformacion)
        {
            // TODO: 2 PUNTOS
            return laInformacion.fecha.Month;
        }

        public string ComoTexto()
        {
            return new MesComoTexto(mes).ComoTexto();
        }
    }
}
