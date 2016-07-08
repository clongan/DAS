using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetos;

namespace ConObjetos_Tests
{
    [TestClass]
    public class TasaBruta_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void ObtenerTasaBruta_Tests()
        {
            elResultadoEsperado = 11.9679979015017;
            double valorFacial = 320000;
            double valorTransadoNeto = 300000;
            double tasaDeImpuesto = 0.08;
            double diasAlVencimiento = new DiasAlVencimiento(new DateTime(2016, 10, 10), new DateTime(2016, 3, 3)).DiasTotales();
            elResultadoObtenido = new TasaBruta(valorFacial, valorTransadoNeto, tasaDeImpuesto, diasAlVencimiento).ObtenerTasaBruta();
            
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido,0.0000000000001);
        }
    }
}
