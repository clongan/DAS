using System;

namespace ConParameterObject
{
    public class FechaComoTexto
    {
        string dia;
        string mes;
        string año;

        public FechaComoTexto(DateTime fecha)
        {
            dia = ObtenerDiaDeFechaCompleta(fecha);
            mes = ObtenerMesDeFechaCompleta(fecha);
            año = ObtenerAñoDeFechaCompleta(fecha);
        }

        private string ObtenerDiaDeFechaCompleta(DateTime fecha)
        {
            return new Dia(fecha).ComoTexto();
        }

        private string ObtenerMesDeFechaCompleta(DateTime fecha)
        {
            return new Mes(fecha).ComoTexto();
        }

        private string ObtenerAñoDeFechaCompleta(DateTime fecha)
        {
            return new Año(fecha).ComoTexto();
        }

        public string ComoTexto()
        {
            return año + mes + dia;
        }
    }
}
