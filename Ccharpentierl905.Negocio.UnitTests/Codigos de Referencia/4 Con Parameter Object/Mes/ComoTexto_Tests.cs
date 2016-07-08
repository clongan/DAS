using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConParameterObject;

namespace ConParameterObject_Tests
{
    [TestClass]
    public class CodigosDeReferencia_ConParameterObject_Mes_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_UnaFecha_GeneraElMes()
        {
            elResultadoEsperado = "10";
            elResultadoObtenido = new Mes(new DateTime(2016, 10, 10)).ComoTexto();
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

    }
}
