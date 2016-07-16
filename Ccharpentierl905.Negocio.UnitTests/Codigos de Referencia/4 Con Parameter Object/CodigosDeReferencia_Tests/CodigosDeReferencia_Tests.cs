using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodigosDeReferencia.ConParameterObject;
using System;

namespace ConParameterObject.CodigosDeReferencia_TESTS
{
    [TestClass]
    public class ConParameterObject_CodigosDeReferencia_Tests
    {
        private string elResultadoObtenido;
        private string elResultadoEsperado;
        private InformacionDelCodigoDeReferencia laInformacion;

        [TestMethod]
        public void GenerarCodigoDeReferencia_GeneraDosVerificadores_TruncaAUnDigito()
        {
            elResultadoEsperado = "20001111333228888888888881";

            laInformacion = new InformacionDelCodigoDeReferencia();
            laInformacion.fecha = new DateTime(2000, 11, 11);
            laInformacion.cliente = "333";
            laInformacion.sistema = "22";
            laInformacion.consecutivo = "888888888888";

            elResultadoObtenido = CalculosDeCodigosDeReferencia.GenerarCodigoDeReferencia(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenerarCodigoDeReferencia_ClienteTieneMenosDígitos_PrecedeConCero()
        {
            elResultadoEsperado = "20001111033228888888888885";

            laInformacion = new InformacionDelCodigoDeReferencia();
            laInformacion.fecha = new DateTime(2000, 11, 11);
            laInformacion.cliente = "33";
            laInformacion.sistema = "22";
            laInformacion.consecutivo = "888888888888";

            elResultadoObtenido = CalculosDeCodigosDeReferencia.GenerarCodigoDeReferencia(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenerarCodigoDeReferencia_SistemaTieneSoloUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20001111333028888888888884";
            laInformacion = new InformacionDelCodigoDeReferencia();
            laInformacion.fecha = new DateTime(2000, 11, 11);
            laInformacion.cliente = "333";
            laInformacion.sistema = "2";
            laInformacion.consecutivo = "888888888888";

            elResultadoObtenido = CalculosDeCodigosDeReferencia.GenerarCodigoDeReferencia(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenerarCodigoDeReferencia_MesTieneSoloUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20000111333228888888888885";
            laInformacion = new InformacionDelCodigoDeReferencia();
            laInformacion.fecha = new DateTime(2000, 1, 11);
            laInformacion.cliente = "333";
            laInformacion.sistema = "22";
            laInformacion.consecutivo = "888888888888";

            elResultadoObtenido = CalculosDeCodigosDeReferencia.GenerarCodigoDeReferencia(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenerarCodigoDeReferencia_DiaTieneSoloUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20001101333228888888888883";

            laInformacion = new InformacionDelCodigoDeReferencia();
            laInformacion.fecha = new DateTime(2000, 11, 1);
            laInformacion.cliente = "333";
            laInformacion.sistema = "22";
            laInformacion.consecutivo = "888888888888";

            elResultadoObtenido = CalculosDeCodigosDeReferencia.GenerarCodigoDeReferencia(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenerarCodigoDeReferencia_ConsecutivoTieneMenosDígitos_PrecedeConCeros()
        {
            elResultadoEsperado = "20001111333220000000000047";

            laInformacion = new InformacionDelCodigoDeReferencia();
            laInformacion.fecha = new DateTime(2000, 11, 11);
            laInformacion.cliente = "333";
            laInformacion.sistema = "22";
            laInformacion.consecutivo = "4";

            elResultadoObtenido = CalculosDeCodigosDeReferencia.GenerarCodigoDeReferencia(laInformacion);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
