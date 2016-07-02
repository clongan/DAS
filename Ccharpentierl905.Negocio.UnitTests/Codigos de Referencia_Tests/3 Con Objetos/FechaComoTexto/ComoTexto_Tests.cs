using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetos;

namespace ConObjetos_Tests
{
    [TestClass]
    public class CodigosDeReferencia_ConObjetos_FechaComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_UnaFecha_FechaComoTexto()
        {
            elResultadoEsperado = "20000111";
            elResultadoObtenido = new FechaComoTexto(new DateTime(2000, 1, 11)).ComoTexto();
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

    }
}
