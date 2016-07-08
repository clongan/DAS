using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConParameterObject;

namespace ConParameterObject_Tests
{
    [TestClass]
    public class CodigosDeReferencia_ConParameterObject_CodigoDeReferenciaSinVerificador_Tests
    {
        private object elResultadoEsperado;
        private object elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_GeneraCodigoDeReferenciaSinVerificador()
        {
            elResultadoEsperado = "2000111133322888888888888";
            elResultadoObtenido = new CodigoDeReferenciaSinVerificador(new DateTime(2000, 11, 11), "333", "22", "888888888888").ComoTexto();
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
