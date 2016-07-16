using ConParameterObject.Calculos;

namespace CodigosDeReferencia.ConParameterObject
{
    public class CodigoDeReferenciaCompleto
    {
        string codigoDeReferenciaSinVerificador;
        int verificador;

        public CodigoDeReferenciaCompleto(InformacionDelCodigoDeReferencia laInformacion)
        {
            codigoDeReferenciaSinVerificador = ObtenerCodigoDeReferenciaSinVerificador(laInformacion);
            verificador = ObtenerElDigitoVerificador(codigoDeReferenciaSinVerificador);
        }

        private string ObtenerCodigoDeReferenciaSinVerificador(InformacionDelCodigoDeReferencia laInformacion)
        {
            return new CodigoDeReferenciaSinVerificador(laInformacion).ComoTexto();
        }

        private int ObtenerElDigitoVerificador(string codigoDeReferenciaSinVerificador)
        {
            return CalculoDeDigitoVerificador.CalculeElDigitoVerificador(codigoDeReferenciaSinVerificador);
        }

        public string ObtenerCodigoDeReferencia()
        {
            return codigoDeReferenciaSinVerificador + verificador;
        }
    }
}
