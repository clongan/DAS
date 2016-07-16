using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodigosDeReferencia.ConParameterObject;

namespace ConParameterObject_Tests
{
    [TestClass]
    public class ConParameterObject_CodigosDeReferencia_Dia_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private InformacionDelCodigoDeReferencia laInformacionDelCodigo;

        [TestMethod]
        public void ComoTexto_UnaFecha_GeneraElDia()
        {
            elResultadoEsperado = "10";
            laInformacionDelCodigo = new InformacionDelCodigoDeReferencia();
            laInformacionDelCodigo.fecha = new DateTime(2016, 10, 10);
            elResultadoObtenido = new Dia(laInformacionDelCodigo).ComoTexto();
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

    }
}
