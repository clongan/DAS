using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConObjetos
{
    public class ValorTransadoBruto
    {
        private double diasAlVencimiento;
        private double tasaBruta;
        private double valorFacial;

        public ValorTransadoBruto(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto,
            DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            this.valorFacial = valorFacial;
            diasAlVencimiento = ObtenerDiasAlVencimiento(fechaDeVencimiento, fechaActual);
            tasaBruta = ObtenerTasaBruta(valorFacial, valorTransadoNeto, tasaDeImpuesto);
        }

        private double ObtenerDiasAlVencimiento(DateTime fechaDeVencimiento, DateTime fechaActual)
        {
            return new DiasAlVencimiento(fechaDeVencimiento, fechaActual).DiasTotales();
        }

        private double ObtenerTasaBruta(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto)
        {
            return new TasaBruta(valorFacial, valorTransadoNeto, tasaDeImpuesto, diasAlVencimiento).ObtenerTasaBruta();
        }

        public double ObtenerValorTransadoBruto()
        {
            return valorFacial / (1 + ((tasaBruta / 100) * (diasAlVencimiento / 365)));
        }

    }
}
