namespace RendimientosPorDescuento.ConObjetos
{
    public class TasaBruta
    {
        private double tasaDeImpuesto;
        private double tasaNeta;

        public TasaBruta(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, double diasAlVencimiento)
        {
            this.tasaDeImpuesto = tasaDeImpuesto;
            tasaNeta = CalcularTasaNeta(valorFacial, valorTransadoNeto, tasaDeImpuesto, diasAlVencimiento);
        }

        private double CalcularTasaNeta(double valorFacial, double valorTransadoNeto, double tasaDeImpuesto, double diasAlVencimiento)
        {
            return ((valorFacial - valorTransadoNeto) / (valorTransadoNeto * (diasAlVencimiento / 365))) * 100;
        }

        public double ObtenerTasaBruta()
        {
            return tasaNeta / (1 - tasaDeImpuesto);
        }

    }
}
