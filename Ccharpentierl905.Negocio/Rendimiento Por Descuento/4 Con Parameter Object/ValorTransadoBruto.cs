using System;

namespace RendimientosPorDescuento.ConParameterObject
{
    public class ValorTransadoBruto
    {
        private double diasAlVencimiento;
        private double tasaBruta;
        private double valorFacial;

        public ValorTransadoBruto(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            this.valorFacial = laInformacion.valorFacial;
            diasAlVencimiento = ObtenerDiasAlVencimiento(laInformacion);
            tasaBruta = ObtenerTasaBruta(laInformacion, diasAlVencimiento);
        }

        private double ObtenerDiasAlVencimiento(LaInformacionDelRendimientoPorDescuento laInformacion)
        {
            return new DiasAlVencimiento(laInformacion).DiasTotales();
        }

        private double ObtenerTasaBruta(LaInformacionDelRendimientoPorDescuento laInformacion, double diasAlVencimiento)
        {
            return new TasaBruta(laInformacion, diasAlVencimiento).ObtenerTasaBruta();
        }

        public double ObtenerValorTransadoBruto()
        {
            return valorFacial / (1 + ((tasaBruta / 100) * (diasAlVencimiento / 365)));
        }

    }
}
