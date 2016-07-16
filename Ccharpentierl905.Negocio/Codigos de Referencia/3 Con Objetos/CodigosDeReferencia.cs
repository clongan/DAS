using System;

namespace CodigosDeReferencia.ConObjetos
{
    public class CalculosDeCodigosDeReferencia
    {
        public static string GenerarCodigoDeReferencia(DateTime fecha, string cliente,
            string sistema, string consecutivo)
        {
            return new CodigoDeReferenciaCompleto(fecha, cliente, sistema, consecutivo).ObtenerCodigoDeReferencia();
        }

    }
}
