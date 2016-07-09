using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetos;

namespace ConObjetos_Tests
{
    [TestClass]
    public class ConObjetos_RendimientoPorDescuentoRedondeado_Tests
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
        public void ObtenerRendimientoPorDescuento_RedondeoHaciaArriba_Test()
        {
            elResultadoEsperado = 22159.3592;

            valorFacial = 320500;
            valorTransadoNeto = 300000;
            tasaDeImpuesto = 0.08;
            fechaDeVencimiento = new DateTime(2016, 10, 10);
            fechaActual = new DateTime(2016, 3, 3);
            tratamientoFiscal = true;

            elResultadoObtenido = RendimientoPorDescuento.DeterminarRendimientoPorDescuento(valorFacial, valorTransadoNeto,
                tasaDeImpuesto, fechaDeVencimiento, fechaActual, tratamientoFiscal);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ObtenerRendimientoPorDescuento_RedondeoHaciaAbajo_Test()
        {
            elResultadoEsperado = 21621.6216;

            valorFacial = 320000;
            valorTransadoNeto = 300000;
            tasaDeImpuesto = 0.08;
            fechaDeVencimiento = new DateTime(2016, 10, 10);
            fechaActual = new DateTime(2016, 3, 3);
            tratamientoFiscal = true;

            elResultadoObtenido = RendimientoPorDescuento.DeterminarRendimientoPorDescuento(valorFacial, valorTransadoNeto,
                tasaDeImpuesto, fechaDeVencimiento, fechaActual, tratamientoFiscal);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
