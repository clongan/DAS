using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConParameterObject;

namespace ConParameterObject_Tests
{
    [TestClass]
    public class ConParameterObject_CodigosDeReferencia_CodigoDeReferenciaCompleto_Tests
    {
        private object elResultadoEsperado;
        private object elResultadoObtenido;
        private InformacionDelCodigoDeReferencia laInformacionDelCodigoDeReferencia;

        [TestMethod]
        public void ComoTexto_GeneraCodigoDeReferenciaCompleto()
        {
            elResultadoEsperado = "20001111333228888888888881";
            laInformacionDelCodigoDeReferencia = new InformacionDelCodigoDeReferencia();
            laInformacionDelCodigoDeReferencia.fecha = new DateTime(2000, 11, 11);
            laInformacionDelCodigoDeReferencia.cliente = "333";
            laInformacionDelCodigoDeReferencia.sistema = "22";
            laInformacionDelCodigoDeReferencia.consecutivo = "888888888888";
            elResultadoObtenido = new CodigoDeReferenciaCompleto(laInformacionDelCodigoDeReferencia).ObtenerCodigoDeReferencia();
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
