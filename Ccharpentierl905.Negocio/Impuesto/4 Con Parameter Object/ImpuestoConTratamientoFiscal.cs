using System;
using RendimientosPorDescuento.ConParameterObject;

namespace Impuestos.ConParameterObject
{
    public class ImpuestoConTratamientoFiscal
    {
        private double valorTransadoBruto;
        private double valorTransadoNeto;

        public ImpuestoConTratamientoFiscal(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            // TODO: 2 PUNTOS
            this.valorTransadoNeto = laInformacion.valorTransadoNeto;
            valorTransadoBruto = new ValorTransadoBruto(laInformacion).ObtenerValorTransadoBruto();
        }

        public double CalcularImpuesto()
        {
            return  valorTransadoNeto - valorTransadoBruto;
        }
    }
}
