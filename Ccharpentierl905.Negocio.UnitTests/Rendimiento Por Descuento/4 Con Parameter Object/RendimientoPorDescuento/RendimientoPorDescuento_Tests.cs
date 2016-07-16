using Microsoft.VisualStudio.TestTools.UnitTesting;
using RendimientosPorDescuento.ConParameterObject;
using System;

namespace ConParameterObject_TESTS
{
    [TestClass]
    public class ConParameterObject_RendimientoPorDescuento_Tests
    {
        private double elResultadoObtenido;
        private double elResultadoEsperado;
        private LaInformacionDelRendimientoPorDescuento laInformacion;

        [TestMethod]
        public void GeneraRendimientoPorDescuento_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = 21621.6216;

            laInformacion = new LaInformacionDelRendimientoPorDescuento();
            laInformacion.valorFacial = 320000;
            laInformacion.valorTransadoNeto = 300000;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);
            laInformacion.tieneTratamientoFiscal = true;

            elResultadoObtenido = RendimientoPorDescuento.DeterminarRendimientoPorDescuento(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GeneraRendimientoPorDescuento_TieneTratamientoFiscal_RedondeoHaciaArriba()
        {
            elResultadoEsperado = 22159.3592;

            laInformacion = new LaInformacionDelRendimientoPorDescuento();
            laInformacion.valorFacial = 320500;
            laInformacion.valorTransadoNeto = 300000;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);
            laInformacion.tieneTratamientoFiscal = true;

            elResultadoObtenido = RendimientoPorDescuento.DeterminarRendimientoPorDescuento(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GeneraRendimientoPorDescuento_NoTieneTratamientoFiscal_SinRedondeo()
        {
            elResultadoEsperado = 19999.9999;

            laInformacion = new LaInformacionDelRendimientoPorDescuento();
            laInformacion.valorFacial = 320000;
            laInformacion.valorTransadoNeto = 300000.0001;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);
            laInformacion.tieneTratamientoFiscal = false;

            elResultadoObtenido = RendimientoPorDescuento.DeterminarRendimientoPorDescuento(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
