using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidacionDeDatos.ConParameterObject;

namespace ConParameterObject_Tests
{
    [TestClass]
    public class ConParameterObject_DeterminarValidezDeDatos_Tests
    {
        private bool elResultadoEsperado;
        private bool elResultadoObtenido;
        private DateTime fechaActual;
        private DateTime fechaDeVencimiento;
        private LaInformacionDeValidacion laInformacion;
        private double tasaDeImpuesto;
        private int valorFacial;
        private int valorTransadoNeto;

        [TestMethod]
        public void DeterminarSiEsValido_EsValido()
        {
            elResultadoEsperado = true;

            laInformacion = new LaInformacionDeValidacion();
            laInformacion.valorFacial = 300000;
            laInformacion.valorTransadoNeto = 300000;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = new DeterminarValidezDeDatos(laInformacion).DeterminarSiEsValido();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void DeterminarSiEsValido_NoEsValido()
        {
            elResultadoEsperado = false;

            laInformacion = new LaInformacionDeValidacion();
            laInformacion.valorFacial = 100000;
            laInformacion.valorTransadoNeto = 300000;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new DeterminarValidezDeDatos(laInformacion).DeterminarSiEsValido();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
