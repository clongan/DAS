using System;

namespace CodigosDeReferencia.ConObjetos
{
    public class Mes
    {
        private int mes;

        public Mes(DateTime fecha)
        {
            mes = ObtenerMesDeFechaCompleta(fecha);
        }

        public int ObtenerMesDeFechaCompleta(DateTime fecha)
        {
            return fecha.Month;
        }

        public string ComoTexto()
        {
            return new MesComoTexto(mes).ComoTexto();
        }
    }
}
