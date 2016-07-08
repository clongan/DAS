using Ccharpentierl905.Negocio.ConParameterObject.Calculos;
using System;

namespace ConParameterObject
{
    public class CodigoDeReferenciaCompleto
    {
        string codigoDeReferenciaSinVerificador;
        int verificador;

        public CodigoDeReferenciaCompleto(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            codigoDeReferenciaSinVerificador = ObtenerCodigoDeReferenciaSinVerificador(laInformacionDelCodigo);
            verificador = ObtenerElDigitoVerificador(codigoDeReferenciaSinVerificador);
        }

        private string ObtenerCodigoDeReferenciaSinVerificador(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            return new CodigoDeReferenciaSinVerificador(laInformacionDelCodigo).ComoTexto();
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
