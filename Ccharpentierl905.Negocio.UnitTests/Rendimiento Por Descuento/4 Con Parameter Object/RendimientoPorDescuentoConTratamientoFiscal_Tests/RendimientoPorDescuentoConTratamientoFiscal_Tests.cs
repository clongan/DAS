using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RendimientosPorDescuento.ConParameterObject;

namespace ConParameterObject_Tests
{
    [TestClass]
    public class ConParameterObject_RendimientoPorDescuento_RendimientoPorDescuentoConTratamientoFiscal_Test
    {
        private double elResultadoObtenido;
        private double elResultadoEsperado;
        private LaInformacionDelRendimientoPorDescuento laInformacion;

        [TestMethod]
        public void RendimientoPorDescuento_ConTratamientoFiscal()
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
    }
}
