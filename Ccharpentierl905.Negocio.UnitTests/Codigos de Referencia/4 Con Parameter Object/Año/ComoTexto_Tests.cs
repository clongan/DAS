using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConParameterObject;

namespace ConParameterObject_Tests
{
    [TestClass]
    public class ConParameterObject_CodigosDeReferencia_Año_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionDelCodigoDeReferencia laInformacionDelCodigo;

        [TestMethod]
        public void ComoTexto_UnaFecha_GeneraElAño()
        {
            elResultadoEsperado = "2016";
            laInformacionDelCodigo = new InformacionDelCodigoDeReferencia();
            laInformacionDelCodigo.fecha = new DateTime(2016, 10, 10);
            elResultadoObtenido = new Año(laInformacionDelCodigo).ComoTexto();
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

    }
}
