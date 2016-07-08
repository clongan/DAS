using System;

namespace ConParameterObject
{
    public class CodigosDeReferencia
    {
        public static string GenerarCodigoDeReferencia(InformacionDelCodigoDeReferencia informacionDelCodigoDeReferencia)
        {
            return new CodigoDeReferenciaCompleto(informacionDelCodigoDeReferencia).ObtenerCodigoDeReferencia();
        }

    }
}
