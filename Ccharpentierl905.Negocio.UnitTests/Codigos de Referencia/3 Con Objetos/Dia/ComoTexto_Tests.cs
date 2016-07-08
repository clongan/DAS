using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetos;

namespace ConObjetos_Tests
{
    [TestClass]
    public class CodigosDeReferencia_ConObjetos_Dia_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_UnaFecha_GeneraElDia()
        {
            elResultadoEsperado = "10";
            elResultadoObtenido = new Dia(new DateTime(2016, 10, 10)).ComoTexto();
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

    }
}
