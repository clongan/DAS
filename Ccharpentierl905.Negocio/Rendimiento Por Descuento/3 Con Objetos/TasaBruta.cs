using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConObjetos
{
    public class TasaBruta
    {
        private double tasaDeImpuesto;
        private double tasaNeta;

        public TasaBruta(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, double diasAlVencimiento)
        {
            this.tasaDeImpuesto = tasaDeImpuesto;
            tasaNeta = ((valorFacial - valorTransadoNeto) / (valorTransadoNeto * (diasAlVencimiento / 365))) * 100;
        }

        public double ObtenerTasaBruta()
        {
            return tasaNeta / (1 - tasaDeImpuesto);
        }

    }
}
