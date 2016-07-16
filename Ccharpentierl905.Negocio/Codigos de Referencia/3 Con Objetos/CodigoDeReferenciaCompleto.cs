using ConObjetos.Calculos;
using System;

namespace CodigosDeReferencia.ConObjetos
{
    public class CodigoDeReferenciaCompleto
    {
        string codigoDeReferenciaSinVerificador;
        int verificador;

        public CodigoDeReferenciaCompleto(DateTime fecha, string cliente,
            string sistema, string consecutivo)
        {
            codigoDeReferenciaSinVerificador = ObtenerCodigoDeReferenciaSinVerificador(fecha, cliente, sistema, consecutivo);
            verificador = ObtenerElDigitoVerificador(codigoDeReferenciaSinVerificador);
        }

        private string ObtenerCodigoDeReferenciaSinVerificador(DateTime fecha, string cliente,
            string sistema, string consecutivo)
        {
            return new CodigoDeReferenciaSinVerificador(fecha, cliente, sistema, consecutivo).ComoTexto();
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
