using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impuestos.ConObjetos;

namespace ConObjetos_Tests
{
    [TestClass]
    public class ConObjetos_ImpuestoRedondeado_Tests
    {
        private double elResultadoObtenido;
        private double elResultadoEsperado;
        private double valorFacial;
        private double valorTransadoNeto;
        private double tasaDeImpuesto;
        private DateTime fechaDeVencimiento;
        private DateTime fechaActual;
        private Boolean tratamientoFiscal;

        [TestMethod]
        public void ObtenerImpuesto_RedondeoHaciaArriba_Test()
        {
            elResultadoEsperado = 1659.3592;

            valorFacial = 320500;
            valorTransadoNeto = 300000;
            tasaDeImpuesto = 0.08;
            fechaDeVencimiento = new DateTime(2016, 10, 10);
            fechaActual = new DateTime(2016, 3, 3);
            tratamientoFiscal = true;

            elResultadoObtenido = Impuesto.DeterminarImpuesto(valorFacial, valorTransadoNeto,
                tasaDeImpuesto, fechaDeVencimiento, fechaActual, tratamientoFiscal);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ObtenerImpuesto_RedondeoHaciaAbajo_Test()
        {
            elResultadoEsperado = 1621.6216;

            valorFacial = 320000;
            valorTransadoNeto = 300000;
            tasaDeImpuesto = 0.08;
            fechaDeVencimiento = new DateTime(2016, 10, 10);
            fechaActual = new DateTime(2016, 3, 3);
            tratamientoFiscal = true;

            elResultadoObtenido = Impuesto.DeterminarImpuesto(valorFacial, valorTransadoNeto,
                tasaDeImpuesto, fechaDeVencimiento, fechaActual, tratamientoFiscal);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
