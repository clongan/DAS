using System;

namespace ConParameterObject
{
    public class CodigoDeReferenciaSinVerificador
    {
        string fechaCompletaComoTexto;
        string clienteFormateado;
        string sistemaFormateado;
        string consecutivoFormateado;

        public CodigoDeReferenciaSinVerificador(DateTime fecha, string cliente, string sistema, string consecutivo)
        {
            fechaCompletaComoTexto = ObtenerFechaCompletaComoTexto(fecha);
            clienteFormateado = ObtenerClienteFormateado(cliente);
            sistemaFormateado = ObtenerSistemaFormateado(sistema);
            consecutivoFormateado = ObtenerConsecutivoFormateado(consecutivo);
        }

        private string ObtenerFechaCompletaComoTexto(DateTime fecha)
        {
            return new FechaComoTexto(fecha).ComoTexto();
        }

        private string ObtenerClienteFormateado(string cliente)
        {
            return cliente.PadLeft(3, '0');
        }

        private string ObtenerSistemaFormateado(string sistema)
        {
            return sistema.PadLeft(2, '0');
        }

        private string ObtenerConsecutivoFormateado(string consecutivo)
        {
            return consecutivo.PadLeft(12, '0');
        }

        public string ComoTexto()
        {
            return fechaCompletaComoTexto + clienteFormateado + sistemaFormateado + consecutivoFormateado;
        }
    }
}
