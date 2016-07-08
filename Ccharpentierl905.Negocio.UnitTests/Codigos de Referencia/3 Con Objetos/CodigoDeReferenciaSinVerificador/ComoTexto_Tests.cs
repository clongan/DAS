using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetos;

namespace ConObjetos_Tests
{
    [TestClass]
    public class CodigosDeReferencia_ConObjetos_CodigoDeReferenciaSinVerificador_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_GeneraCodigoDeReferenciaSinVerificador()
        {
            elResultadoEsperado = "2000111133322888888888888";
            elResultadoObtenido = new CodigoDeReferenciaSinVerificador(new DateTime(2000, 11, 11), "333", "22", "888888888888").ComoTexto();
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
