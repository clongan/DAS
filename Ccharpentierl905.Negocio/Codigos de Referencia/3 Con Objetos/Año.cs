using System;

namespace ConObjetos
{
    public class Año
    {
        private int año;

        public Año()
        {
        }

        public Año(DateTime fecha)
        {
            año = fecha.Year;
        }

        public string ComoTexto()
        {
            return año.ToString();
        }
    }
}
