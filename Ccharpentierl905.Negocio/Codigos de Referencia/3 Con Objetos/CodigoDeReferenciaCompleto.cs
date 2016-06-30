using Ccharpentierl905.Negocio.ConObjetos.Calculos;
using System;

namespace ConObjetos
{
    public class CodigoDeReferenciaCompleto
    {
        string codigoDeReferenciaSinVerificador;
        int verificador;

        public CodigoDeReferenciaCompleto(DateTime fecha, string cliente,
            string sistema, string consecutivo)
        {
            codigoDeReferenciaSinVerificador = new CodigoDeReferenciaSinVerificador(fecha, cliente, sistema, consecutivo).ComoTexto();
            verificador = CalculoDeDigitoVerificador.CalculeElDigitoVerificador(codigoDeReferenciaSinVerificador);
        }
        public string ObtenerCodigoDeReferencia()
        {
            return codigoDeReferenciaSinVerificador + verificador;
        }
    }
}
