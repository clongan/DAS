using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidacionDeDatos.ConParameterObject;

namespace ConObjetos_Tests
{
    [TestClass]
    public class ConParameterObject_ValidacionDeDatos_Tests
    {
        private bool elResultadoEsperado;
        private bool elResultadoObtenido;
        private LaInformacionDeValidacion laInformacion;

        [TestMethod]
        public void ValidacionDeDatos_ValorFacialIgualACienMil_False()
        {
            elResultadoEsperado = false;

            laInformacion = new LaInformacionDeValidacion();
            laInformacion.valorFacial = 100000;
            laInformacion.valorTransadoNeto = 300000;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 3, 3);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = ValidacionDeDato.ValidarDatos(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionDeDatos_ValorTransadoNetoIgualACienMil_False()
        {
            elResultadoEsperado = false;

            laInformacion = new LaInformacionDeValidacion();
            laInformacion.valorFacial = 300000;
            laInformacion.valorTransadoNeto = 100000;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = ValidacionDeDato.ValidarDatos(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionDeDatos_TasaDeImpuestoIgualQueCero_False()
        {
            elResultadoEsperado = false;

            laInformacion = new LaInformacionDeValidacion();
            laInformacion.valorFacial = 300000;
            laInformacion.valorTransadoNeto = 300000;
            laInformacion.tasaDeImpuesto = 0.00;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = ValidacionDeDato.ValidarDatos(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionDeDatos_TasaDeImpuestoMayorQueUno_False()
        {
            elResultadoEsperado = false;

            laInformacion = new LaInformacionDeValidacion();
            laInformacion.valorFacial = 300000;
            laInformacion.valorTransadoNeto = 300000;
            laInformacion.tasaDeImpuesto = 1.00;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = ValidacionDeDato.ValidarDatos(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionDeDatos_FechaActualMayorOIgualQueFechaDeVencimiento_False()
        {
            elResultadoEsperado = false;

            laInformacion = new LaInformacionDeValidacion();
            laInformacion.valorFacial = 300000;
            laInformacion.valorTransadoNeto = 300000;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 3, 3);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = ValidacionDeDato.ValidarDatos(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValidacionDeDatos_TodosValidos_True()
        {
            elResultadoEsperado = true;

            laInformacion = new LaInformacionDeValidacion();
            laInformacion.valorFacial = 300000;
            laInformacion.valorTransadoNeto = 300000;
            laInformacion.tasaDeImpuesto = 0.08;
            laInformacion.fechaDeVencimiento = new DateTime(2016, 10, 10);
            laInformacion.fechaActual = new DateTime(2016, 3, 3);

            elResultadoObtenido = ValidacionDeDato.ValidarDatos(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
