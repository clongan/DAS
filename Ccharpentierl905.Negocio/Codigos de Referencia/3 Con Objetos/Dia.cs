using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConObjetos
{
    public class Dia
    {
        private int dia;

        public Dia(DateTime fecha)
        {
            dia = fecha.Day;
        }

        public string ComoTexto()
        {
            return dia.ToString().PadLeft(2, '0');
        }

    }
}
