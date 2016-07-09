using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConParameterObject;

namespace ConParameterObject_Tests
{
    [TestClass]
    public class ConParameterObject_CodigosDeReferencia_CodigoDeReferenciaSinVerificador_Tests
    {
        private object elResultadoEsperado;
        private object elResultadoObtenido;
        private InformacionDelCodigoDeReferencia laInformacionDelCodigoDeReferencia;

        [TestMethod]
        public void ComoTexto_GeneraCodigoDeReferenciaSinVerificador()
        {
            elResultadoEsperado = "2000111133322888888888888";
            laInformacionDelCodigoDeReferencia = new InformacionDelCodigoDeReferencia();
            laInformacionDelCodigoDeReferencia.fecha = new DateTime(2000, 11, 11);
            laInformacionDelCodigoDeReferencia.cliente = "333";
            laInformacionDelCodigoDeReferencia.sistema = "22";
            laInformacionDelCodigoDeReferencia.consecutivo = "888888888888";
            elResultadoObtenido = new CodigoDeReferenciaSinVerificador(laInformacionDelCodigoDeReferencia).ComoTexto();
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
