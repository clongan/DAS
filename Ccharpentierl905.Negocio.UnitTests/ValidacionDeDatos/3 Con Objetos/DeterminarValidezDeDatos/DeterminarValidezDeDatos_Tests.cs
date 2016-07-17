using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidacionDeDatos.ConObjetos;

namespace ConObjetos_Tests
{
    [TestClass]
    public class ConObjetos_DeterminarValidezDeDatos_Tests
    {
        private bool elResultadoEsperado;
        private bool elResultadoObtenido;
        private DateTime fechaActual;
        private DateTime fechaDeVencimiento;
        private double tasaDeImpuesto;
        private int valorFacial;
        private int valorTransadoNeto;

        [TestMethod]
        public void DeterminarSiEsValido_EsValido()
        {
            elResultadoEsperado = true;
            valorFacial = 300000;
            valorTransadoNeto = 300000;
            tasaDeImpuesto = 0.08;
            fechaDeVencimiento = new DateTime(2016, 10, 10);
            fechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new DeterminarValidezDeDatos(valorFacial, valorTransadoNeto, tasaDeImpuesto,
             fechaDeVencimiento, fechaActual).DeterminarSiEsValido();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void DeterminarSiEsValido_NoEsValido()
        {
            elResultadoEsperado = false;
            valorFacial = 100000;
            valorTransadoNeto = 300000;
            tasaDeImpuesto = 0.08;
            fechaDeVencimiento = new DateTime(2016, 10, 10);
            fechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new DeterminarValidezDeDatos(valorFacial, valorTransadoNeto, tasaDeImpuesto,
             fechaDeVencimiento, fechaActual).DeterminarSiEsValido();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
