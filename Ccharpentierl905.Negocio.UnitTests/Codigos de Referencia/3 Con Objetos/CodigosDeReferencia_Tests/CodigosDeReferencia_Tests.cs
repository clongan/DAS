using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConObjetos.CodigosDeReferencia_TESTS
{
    [TestClass]
    public class CodigosDeReferencia_ConObjetos_Tests
    {
        private string elResultadoObtenido;
        private string elResultadoEsperado;
        private DateTime fecha;
        private string cliente;
        private string sistema;
        private string consecutivo;

        [TestMethod]
        public void GenerarCodigoDeReferencia_GeneraDosVerificadores_TruncaAUnDigito()
        {
            elResultadoEsperado = "20001111333228888888888881";

            fecha = new DateTime(2000, 11, 11);
            cliente = "333";
            sistema = "22";
            consecutivo = "888888888888";

            elResultadoObtenido = CodigosDeReferencia.GenerarCodigoDeReferencia(fecha, cliente,
                sistema, consecutivo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenerarCodigoDeReferencia_ClienteTieneMenosDígitos_PrecedeConCero()
        {
            elResultadoEsperado = "20001111033228888888888885";

            fecha = new DateTime(2000, 11, 11);
            cliente = "33";
            sistema = "22";
            consecutivo = "888888888888";
            elResultadoObtenido = CodigosDeReferencia.GenerarCodigoDeReferencia(fecha, cliente,
                sistema, consecutivo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenerarCodigoDeReferencia_SistemaTieneSoloUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20001111333028888888888884";

            fecha = new DateTime(2000, 11, 11);
            cliente = "333";
            sistema = "2";
            consecutivo = "888888888888";
            elResultadoObtenido = CodigosDeReferencia.GenerarCodigoDeReferencia(fecha, cliente,
                sistema, consecutivo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenerarCodigoDeReferencia_MesTieneSoloUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20000111333228888888888885";

            fecha = new DateTime(2000, 1, 11);
            cliente = "333";
            sistema = "22";
            consecutivo = "888888888888";
            elResultadoObtenido = CodigosDeReferencia.GenerarCodigoDeReferencia(fecha, cliente,
                sistema, consecutivo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenerarCodigoDeReferencia_DiaTieneSoloUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "20001101333228888888888883";

            fecha = new DateTime(2000, 11, 1);
            cliente = "333";
            sistema = "22";
            consecutivo = "888888888888";
            elResultadoObtenido = CodigosDeReferencia.GenerarCodigoDeReferencia(fecha, cliente,
                sistema, consecutivo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenerarCodigoDeReferencia_ConsecutivoTieneMenosDígitos_PrecedeConCeros()
        {
            elResultadoEsperado = "20001111333220000000000047";

            fecha = new DateTime(2000, 11, 11);
            cliente = "333";
            sistema = "22";
            consecutivo = "4";
            elResultadoObtenido = CodigosDeReferencia.GenerarCodigoDeReferencia(fecha, cliente,
                sistema, consecutivo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
