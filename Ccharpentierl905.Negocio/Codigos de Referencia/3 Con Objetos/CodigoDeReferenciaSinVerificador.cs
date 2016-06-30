using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConObjetos
{
    public class CodigoDeReferenciaSinVerificador
    {
        string fechaCompletaComoTexto;
        string clienteFormateado;
        string sistemaFormateado;
        string consecutivoFormateado;

        public CodigoDeReferenciaSinVerificador(DateTime fecha, string cliente, string sistema, string consecutivo)
        {
            fechaCompletaComoTexto = new FechaComoTexto(fecha).ComoTexto();
            clienteFormateado = cliente.PadLeft(3, '0');
            sistemaFormateado = sistema.PadLeft(2, '0');
            consecutivoFormateado = consecutivo.PadLeft(12, '0');
        }
        public string ComoTexto()
        {
            return fechaCompletaComoTexto + clienteFormateado + sistemaFormateado + consecutivoFormateado;
        }
    }
}
