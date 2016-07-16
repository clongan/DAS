using System;

namespace RendimientosPorDescuento.ConParameterObject
{
    public class RendimientoPorDescuentoConTratamientoFiscal
    {
        private double valorFacial;
        private double valorTransadoBruto;

        public RendimientoPorDescuentoConTratamientoFiscal(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            this.valorFacial = laInformacion.valorFacial;
            valorTransadoBruto = ObtenerElValorTransadoBruto(laInformacion);
        }

        private double ObtenerElValorTransadoBruto(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            return new ValorTransadoBruto(laInformacion).ObtenerValorTransadoBruto();
        }

        public double CalcularRendimientoPorDescuento()
        {
            return valorFacial - valorTransadoBruto;
        }
    }
}
