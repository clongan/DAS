using System;

namespace ConObjetos
{
    public class ImpuestoConTratamientoFiscal
    {
        private double valorTransadoBruto;
        private double valorTransadoNeto;

        public ImpuestoConTratamientoFiscal(double valorFacial, double valorTransadoNeto,
            double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            this.valorTransadoNeto = valorTransadoNeto;
            valorTransadoBruto = new ValorTransadoBruto(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual).ObtenerValorTransadoBruto();
        }

        public double CalcularImpuesto()
        {
            return  valorTransadoNeto - valorTransadoBruto;
        }
    }
}
