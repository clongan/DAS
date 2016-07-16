using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RendimientosPorDescuento.ConParameterObject;

namespace ConParameterObject_Tests
{
    [TestClass]
    public class ConParameterObject_TasaBruta_Tests
    {
        private double diasAlVencimiento;
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private LaInformacionDelRendimientoPorDescuento laInformacion;

        [TestMethod]
        public void ObtenerTasaBruta_Tests()
        {
            elResultadoEsperado = 11.9679979015017;

            laInformacion = new LaInformacionDelRendimientoPorDescuento();
            laInformacion.valorFacial = 320000;
            laInformacion.valorTransadoNeto = 300000;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);
            diasAlVencimiento = new DiasAlVencimiento(laInformacion).DiasTotales();
            elResultadoObtenido = new TasaBruta(laInformacion, diasAlVencimiento).ObtenerTasaBruta();
            
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido,0.0000000000001);
        }
    }
}
