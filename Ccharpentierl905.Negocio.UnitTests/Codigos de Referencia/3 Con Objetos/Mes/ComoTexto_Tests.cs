using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetos;

namespace ConObjetos_Tests
{
    [TestClass]
    public class ConObjetos_CodigosDeReferencia_Mes_Tests
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
