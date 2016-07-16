using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RendimientosPorDescuento.ConParameterObject;

namespace ConParameterObject_TESTS
{
    [TestClass]
    public class ConParameterObject_RendimientoPorDescuento_DiasAlVencimiento_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private LaInformacionDelRendimientoPorDescuento laInformacion;

        [TestMethod]
        public void DiasAlVencimiento_DosFechas_Diferencia()
        {
            elResultadoEsperado = 221.00;

            laInformacion = new LaInformacionDelRendimientoPorDescuento();
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual= new DateTime(2016, 3, 3);
            elResultadoObtenido = new DiasAlVencimiento(laInformacion).DiasTotales();

            Assert.AreEqual(elResultadoObtenido, elResultadoEsperado);
        }
    }
}
