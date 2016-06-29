using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConObjetos
{
    class Año
    {
        private int año;

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
