using System;

namespace RendimientosPorDescuento.ConParameterObject
{
    public class LaInformacionDelRendimientoPorDescuento
    {
        public double valorFacial { get; set; }
        public double valorTransadoNeto { get; set; }
        public double tasaDeImpuesto { get; set; }
        public DateTime fechaDeVencimiento { get; set; }
        public DateTime fechaActual { get; set; }
        public bool tieneTratamientoFiscal { get; set; }
    }
}
