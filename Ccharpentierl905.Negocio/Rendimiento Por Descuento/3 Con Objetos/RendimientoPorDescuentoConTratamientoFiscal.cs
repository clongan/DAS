﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConObjetos
{
    public class RendimientoPorDescuentoConTratamientoFiscal
    {
        private double valorFacial;
        private double valorTransadoBruto;

        public RendimientoPorDescuentoConTratamientoFiscal(double valorFacial, double valorTransadoNeto,
            double tasaDeImpuesto, DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            this.valorFacial = valorFacial;
            valorTransadoBruto = new ValorTransadoBruto(valorFacial, valorTransadoNeto, tasaDeImpuesto, fechaDeVencimiento, fechaActual).ObtenerValorTransadoBruto();
        }

        public double CalcularRendimientoPorDescuento()
        {
            return valorFacial - valorTransadoBruto;
        }
    }
}