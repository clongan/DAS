using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetos;

namespace ConObjetos_Tests
{
    [TestClass]
    public class CodigosDeReferencia_CodigoDeReferenciaCompleto_Tests
    {
        private object elResultadoEsperado;
        private object elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_GeneraCodigoDeReferenciaCompleto()
        {
            elResultadoEsperado = "20001111333228888888888881";
            elResultadoObtenido = new CodigoDeReferenciaCompleto(new DateTime(2000, 11, 11), "333", "22", "888888888888").ObtenerCodigoDeReferencia();
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
