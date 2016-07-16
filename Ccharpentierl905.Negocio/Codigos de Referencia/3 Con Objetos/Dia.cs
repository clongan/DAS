using System;

namespace CodigosDeReferencia.ConObjetos
{
    public class Dia
    {
        private int dia;

        public Dia(DateTime fecha)
        {
            dia = ObtenerDiaDeFechaCompleta(fecha);
        }

        public int ObtenerDiaDeFechaCompleta(DateTime fecha)
        {
            return fecha.Day;
        }

        public string ComoTexto()
        {
            return new DiaComoTexto(dia).ComoTexto();
        }
    }
}
