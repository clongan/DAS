using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impuestos.ConParameterObject;
using RendimientosPorDescuento.ConParameterObject;

namespace ConParameterObject_Tests
{
    [TestClass]
    public class ConParameterObject_Impuesto_ImpuestoConTratamientoFiscal_Test
    {
        private double elResultadoObtenido;
        private double elResultadoEsperado;
        private LaInformacionDelRendimientoPorDescuento laInformacion;

        [TestMethod]
        public void Impuesto_ConTratamientoFiscal()
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
