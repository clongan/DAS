using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodigosDeReferencia.ConParameterObject;

namespace ConParameterObject_Tests
{
    [TestClass]
    public class ConParameterObject_CodigosDeReferencia_FechaComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionDelCodigoDeReferencia laInformacionDelCodigo;

        [TestMethod]
        public void ComoTexto_UnaFecha_FechaComoTexto()
        {
            elResultadoEsperado = "20000111";
            laInformacionDelCodigo = new InformacionDelCodigoDeReferencia();
            laInformacionDelCodigo.fecha = new DateTime(2000, 1, 11);
            elResultadoObtenido = new FechaComoTexto(laInformacionDelCodigo).ComoTexto();
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

    }
}
