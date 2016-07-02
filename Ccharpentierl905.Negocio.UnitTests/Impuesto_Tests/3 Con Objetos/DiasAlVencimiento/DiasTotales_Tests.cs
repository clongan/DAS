using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetos;

namespace ConObjetos_TESTS
{
    [TestClass]
    public class Impuesto_DiasAlVencimiento_Tests
    {
        private object elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void DiasAlVencimiento_DosFechas_Diferencia()
        {
            elResultadoEsperado = 221.00;
            elResultadoObtenido = new DiasAlVencimiento(new DateTime(2016, 10, 10), new DateTime(2016, 3, 3)).DiasTotales();
            Assert.AreEqual(elResultadoObtenido, elResultadoEsperado);
        }
    }
}
