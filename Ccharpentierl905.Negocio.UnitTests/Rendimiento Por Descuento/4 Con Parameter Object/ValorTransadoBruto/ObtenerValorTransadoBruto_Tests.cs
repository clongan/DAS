using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RendimientosPorDescuento.ConParameterObject;

namespace ConParameterObject_TESTS
{
    [TestClass]
    public class ConParameterObject_RendimientoPorDescuento_ValorTransadoBruto_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private LaInformacionDelRendimientoPorDescuento laInformacion;

        [TestMethod]
        public void ValorTransadoBruto_ConTratamientoFiscal_Test()
        {
            elResultadoEsperado = 298378.378378378;
            laInformacion = new LaInformacionDelRendimientoPorDescuento();
            laInformacion.valorFacial = 320000;
            laInformacion.valorTransadoNeto = 300000;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new ValorTransadoBruto(laInformacion).ObtenerValorTransadoBruto();
            Assert.AreEqual(elResultadoObtenido, elResultadoEsperado,0.000000001);
        }
    }
}
