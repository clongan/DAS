using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConParameterObject;

namespace ConParameterObject_Tests
{
    [TestClass]
    public class ConParameterObject_CodigosDeReferencia_Dia_Tests
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
