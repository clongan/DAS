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
            dia = ObtenerDiaDeFechaCompleta(fecha);
        }

        public int ObtenerDiaDeFechaCompleta(DateTime fecha)
        {
            return fecha.Day;
        }

        public string ComoTexto()
        {
            return dia.ToString().PadLeft(2, '0');
        }

    }
}
