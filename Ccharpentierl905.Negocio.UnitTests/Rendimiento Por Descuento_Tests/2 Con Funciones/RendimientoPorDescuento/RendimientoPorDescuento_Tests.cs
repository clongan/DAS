using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ccharpentierl905.Negocio.ConFunciones.RendimientoPorDescuento;
using System;

namespace Ccharpentierl905.Negocio.UnitTests.ConFunciones.RendimientoPorDescuento_TESTS
{
    [TestClass]
    public class RendimientoPorDescuento_Tests
    {
        private decimal elResultadoObtenido;
        private decimal elResultadoEsperado;
        private decimal valorFacial;
        private decimal valorTransadoNeto;
        private decimal tasaDeImpuesto;
        private DateTime fechaDeVencimiento;
        private DateTime fechaActual;
        private Boolean tratamientoFiscal;


        [TestMethod]
        public void GeneraRendimientoPorDescuento_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = Convert.ToDecimal(21621.6216);

            valorFacial = 320000;
            valorTransadoNeto = Convert.ToDecimal(300000);
            tasaDeImpuesto = Convert.ToDecimal(0.08);
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
            elResultadoEsperado = Convert.ToDecimal(22159.3592);

            valorFacial = 320500;
            valorTransadoNeto = Convert.ToDecimal(300000);
            tasaDeImpuesto = Convert.ToDecimal(0.08);
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
            elResultadoEsperado = Convert.ToDecimal(19999.9999);

            valorFacial = 320000;
            valorTransadoNeto = Convert.ToDecimal(300000.0001);
            tasaDeImpuesto = Convert.ToDecimal(0.08);
            fechaDeVencimiento = new DateTime(2016, 10, 10);
            fechaActual = new DateTime(2016, 3, 3);
            tratamientoFiscal = false;

            elResultadoObtenido = RendimientoPorDescuento.DeterminarRendimientoPorDescuento(valorFacial, valorTransadoNeto,
                tasaDeImpuesto, fechaDeVencimiento, fechaActual, tratamientoFiscal);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
