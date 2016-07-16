using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impuestos.ConParameterObject;
using RendimientosPorDescuento.ConParameterObject;

namespace ConParameterObject_Tests
{
    [TestClass]
    public class ConParameterObject_ImpuestoRedondeado_Tests
    {
        private double elResultadoObtenido;
        private double elResultadoEsperado;
        private double valorFacial;
        private double valorTransadoNeto;
        private double tasaDeImpuesto;
        private DateTime fechaDeVencimiento;
        private DateTime fechaActual;
        private Boolean tratamientoFiscal;
        private LaInformacionDelRendimientoPorDescuento laInformacion;

        [TestMethod]
        public void ObtenerImpuesto_RedondeoHaciaArriba_Test()
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
        public void ObtenerImpuesto_RedondeoHaciaAbajo_Test()
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
    }
}
