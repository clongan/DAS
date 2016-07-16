using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RendimientosPorDescuento.ConObjetos;

namespace ConObjetos_TESTS
{
    [TestClass]
    public class ConObjetos_RendimientoPorDescuento_ValorTransadoBruto_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void ValorTransadoBruto_ConTratamientoFiscal_Test()
        {
            elResultadoEsperado = 298378.378378378;
            elResultadoObtenido = new ValorTransadoBruto(320000, 300000, 0.08, new DateTime(2016, 10, 10), new DateTime(2016, 3, 3)).ObtenerValorTransadoBruto();
            Assert.AreEqual(elResultadoObtenido, elResultadoEsperado,0.000000001);
        }
    }
}
