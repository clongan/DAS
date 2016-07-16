using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impuestos.ConParameterObject;
using RendimientosPorDescuento.ConParameterObject;
using System;

namespace ConParameterObject_TESTS
{
    [TestClass]
    public class ConObjetos_Impuesto_Tests
    {
        private double elResultadoObtenido;
        private double elResultadoEsperado;
        private LaInformacionDelRendimientoPorDescuento laInformacion;

        [TestMethod]
        public void GeneraImpuesto_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = 1621.6216;

            laInformacion = new LaInformacionDelRendimientoPorDescuento();
            laInformacion.valorFacial = 320000;
            laInformacion.valorTransadoNeto = 300000;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);
            laInformacion.tieneTratamientoFiscal = true;

            elResultadoObtenido = Impuesto.DeterminarImpuesto(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GeneraImpuesto_TieneTratamientoFiscal_RedondeoHaciaArriba()
        {
            elResultadoEsperado = 1659.3592;

            laInformacion = new LaInformacionDelRendimientoPorDescuento();
            laInformacion.valorFacial = 320500;
            laInformacion.valorTransadoNeto = 300000;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);
            laInformacion.tieneTratamientoFiscal = true;

            elResultadoObtenido = Impuesto.DeterminarImpuesto(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GeneraImpuesto_NoTieneTratamientoFiscal_SinRedondeo()
        {
            elResultadoEsperado = 0;

            laInformacion = new LaInformacionDelRendimientoPorDescuento();
            laInformacion.valorFacial = 320000;
            laInformacion.valorTransadoNeto = 300000.0001;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);
            laInformacion.tieneTratamientoFiscal = false;

            elResultadoObtenido = Impuesto.DeterminarImpuesto(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
