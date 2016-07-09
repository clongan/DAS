using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComoUnProcedimiento;

namespace ComoUnProcedimiento_Tests
{
    [TestClass]
    public class ComoUnProcedimiento_ValidacionDeDatos_Tests
    {
        private bool elResultadoEsperado;
        private bool elResultadoObtenido;
        private DateTime fechaActual;
        private DateTime fechaDeVencimiento;
        private double tasaDeImpuesto;
        private double valorFacial;
        private double valorTransadoNeto;

        [TestMethod]
        public void ValidacionDeDatos_ValorFacialIgualACienMil_False()
        {
            elResultadoEsperado = false;

            valorFacial = 100000;
            valorTransadoNeto = 300000;
            tasaDeImpuesto = 0.08;
            fechaDeVencimiento = new DateTime(2016, 3, 3);
            fechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = ValidacionDeDatos.ValidarDatos(valorFacial, valorTransadoNeto, tasaDeImpuesto,
                fechaDeVencimiento, fechaActual);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionDeDatos_ValorTransadoNetoIgualACienMil_False()
        {
            elResultadoEsperado = false;

            valorFacial = 300000;
            valorTransadoNeto = 100000;
            tasaDeImpuesto = 0.08;
            fechaDeVencimiento = new DateTime(2016, 10, 10);
            fechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = ValidacionDeDatos.ValidarDatos(valorFacial, valorTransadoNeto, tasaDeImpuesto,
                fechaDeVencimiento, fechaActual);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionDeDatos_TasaDeImpuestoIgualQueCero_False()
        {
            elResultadoEsperado = false;

            valorFacial = 300000;
            valorTransadoNeto = 300000;
            tasaDeImpuesto = 0.00;
            fechaDeVencimiento = new DateTime(2016, 10, 10);
            fechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = ValidacionDeDatos.ValidarDatos(valorFacial, valorTransadoNeto, tasaDeImpuesto,
                fechaDeVencimiento, fechaActual);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionDeDatos_TasaDeImpuestoMayorQueUno_False()
        {
            elResultadoEsperado = false;

            valorFacial = 300000;
            valorTransadoNeto = 300000;
            tasaDeImpuesto = 1.00;
            fechaDeVencimiento = new DateTime(2016, 10, 10);
            fechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = ValidacionDeDatos.ValidarDatos(valorFacial, valorTransadoNeto, tasaDeImpuesto,
                fechaDeVencimiento, fechaActual);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionDeDatos_FechaActualMayorOIgualQueFechaDeVencimiento_False()
        {
            elResultadoEsperado = false;

            valorFacial = 300000;
            valorTransadoNeto = 300000;
            tasaDeImpuesto = 0.08;
            fechaDeVencimiento = new DateTime(2016, 3, 3);
            fechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = ValidacionDeDatos.ValidarDatos(valorFacial, valorTransadoNeto, tasaDeImpuesto,
                fechaDeVencimiento, fechaActual);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionDeDatos_TodosValidos_True()
        {
            elResultadoEsperado = true;

            valorFacial = 300000;
            valorTransadoNeto = 300000;
            tasaDeImpuesto = 0.08;
            fechaDeVencimiento = new DateTime(2016, 10, 10);
            fechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = ValidacionDeDatos.ValidarDatos(valorFacial, valorTransadoNeto, tasaDeImpuesto,
                fechaDeVencimiento, fechaActual);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
