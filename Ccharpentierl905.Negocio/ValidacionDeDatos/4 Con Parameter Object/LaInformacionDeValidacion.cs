using System;

namespace ValidacionDeDatos.ConParameterObject
{
    public class LaInformacionDeValidacion
    {
        public double valorFacial { get; set; }
        public double valorTransadoNeto { get; set; }
        public double tasaDeImpuesto { get; set; }
        public DateTime fechaDeVencimiento { get; set; }
        public DateTime fechaActual { get; set; }
    }
}
