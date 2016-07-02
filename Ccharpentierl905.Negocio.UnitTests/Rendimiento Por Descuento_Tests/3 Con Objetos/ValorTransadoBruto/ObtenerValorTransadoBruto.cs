using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetos;

namespace ConObjetos_TESTS
{
    [TestClass]
    public class RendimientoPorDescuento_ValorTransadoBruto_Tests
    {
        private object elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void ValorTransadoBruto()
        {
            elResultadoEsperado = 298378.378378378;
            elResultadoObtenido = new ValorTransadoBruto(320000, 300000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3)).ObtenerValorTransadoBruto();
            Assert.AreEqual(elResultadoObtenido, elResultadoEsperado);
        }
    }
}
