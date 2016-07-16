namespace RendimientosPorDescuento.ConParameterObject
{
    public class TasaBruta
    {
        private double tasaDeImpuesto;
        private double tasaNeta;

        public TasaBruta(LaInformacionDelRendimientoPorDescuento laInformacion, double diasAlVencimiento)
        {
            this.tasaDeImpuesto = laInformacion.tasaDeImpuesto;
            tasaNeta = CalcularTasaNeta(laInformacion, diasAlVencimiento);
        }

        private double CalcularTasaNeta(LaInformacionDelRendimientoPorDescuento laInformacion, double diasAlVencimiento)
        {
            return ((laInformacion.valorFacial - laInformacion.valorTransadoNeto) / (laInformacion.valorTransadoNeto * (diasAlVencimiento / 365))) * 100;
        }

        public double ObtenerTasaBruta()
        {
            return tasaNeta / (1 - tasaDeImpuesto);
        }

    }
}
