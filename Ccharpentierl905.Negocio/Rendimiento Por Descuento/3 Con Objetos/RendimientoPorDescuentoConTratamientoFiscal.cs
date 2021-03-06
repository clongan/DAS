﻿using System;

namespace RendimientosPorDescuento.ConObjetos
{
    public class RendimientoPorDescuentoConTratamientoFiscal
    {
        private double valorFacial;
        private double valorTransadoBruto;

        public RendimientoPorDescuentoConTratamientoFiscal(double valorFacial, double valorTransadoNeto,
            double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            this.valorFacial = valorFacial;
            valorTransadoBruto = ObtenerElValorTransadoBruto(valorFacial, valorTransadoNeto,
             tasaDeImpuesto, fechaDeVencimiento, fechaActual);
        }

        private double ObtenerElValorTransadoBruto(double valorFacial, double valorTransadoNeto,
            double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            return new ValorTransadoBruto(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual).ObtenerValorTransadoBruto();
        }

        public double CalcularRendimientoPorDescuento()
        {
            return valorFacial - valorTransadoBruto;
        }
    }
}
