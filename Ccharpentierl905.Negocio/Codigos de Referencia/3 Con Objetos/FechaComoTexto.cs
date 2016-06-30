using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConObjetos
{
    public class FechaComoTexto
    {
        string dia;
        string mes;
        string año;

        public FechaComoTexto(DateTime fecha)
        {
            dia = new Dia(fecha).ComoTexto();
            mes = new Mes(fecha).ComoTexto();
            año = new Año(fecha).ComoTexto();
        }
        public string ComoTexto()
        {
            return año + mes + dia;
        }
    }
}
