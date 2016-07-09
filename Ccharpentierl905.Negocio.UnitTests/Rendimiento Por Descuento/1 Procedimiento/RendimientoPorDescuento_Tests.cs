using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ccharpentierl905.Negocio.ComoUnProcedimiento.RendimientoPorDescuento;
using System;

namespace ComoUnProcedimiento_TESTS
{
    [TestClass]
    public class ComoUnProcedimiento_RendimientoPorDescuento_Tests
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
        public void GeneraRendimientoPorDescuento_TieneTratamientoFiscal_RedondeoHaciaAbajo()
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

        [TestMethod]
        public void GeneraRendimientoPorDescuento_TieneTratamientoFiscal_RedondeoHaciaArriba()
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
        public void GeneraRendimientoPorDescuento_NoTieneTratamientoFiscal_SinRedondeo()
        {
            elResultadoEsperado = 19999.9999;

            valorFacial = 320000;
            valorTransadoNeto = 300000.0001;
            tasaDeImpuesto = 0.08;
            fechaDeVencimiento = new DateTime(2016, 10, 10);
            fechaActual = new DateTime(2016, 3, 3);
            tratamientoFiscal = false;

            elResultadoObtenido = RendimientoPorDescuento.DeterminarRendimientoPorDescuento(valorFacial, valorTransadoNeto,
                tasaDeImpuesto, fechaDeVencimiento, fechaActual, tratamientoFiscal);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
