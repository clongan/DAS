using System;

namespace ValidacionDeDatos.ConObjetos
{
    public class ValidacionDeDato
    {
        public static bool ValidarDatos(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            return new DeterminarValidezDeDatos(valorFacial, valorTransadoNeto, tasaDeImpuesto,
             fechaDeVencimiento, fechaActual).DeterminarSiEsValido();
        }
    }
}
