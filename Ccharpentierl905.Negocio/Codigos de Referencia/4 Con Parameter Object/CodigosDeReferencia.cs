namespace CodigosDeReferencia.ConParameterObject
{
    public class CalculosDeCodigosDeReferencia
    {
        public static string GenerarCodigoDeReferencia(InformacionDelCodigoDeReferencia laInformacion)
        {
            return new CodigoDeReferenciaCompleto(laInformacion).ObtenerCodigoDeReferencia();
        }

    }
}
