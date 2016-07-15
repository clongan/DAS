using System;

namespace ConParameterObject
{
    public class CodigoDeReferenciaSinVerificador
    {
        string fechaCompletaComoTexto;
        string clienteFormateado;
        string sistemaFormateado;
        string consecutivoFormateado;

        public CodigoDeReferenciaSinVerificador(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            fechaCompletaComoTexto = ObtenerFechaCompletaComoTexto(laInformacionDelCodigo);
            clienteFormateado = ObtenerClienteFormateado(laInformacionDelCodigo);
            sistemaFormateado = ObtenerSistemaFormateado(laInformacionDelCodigo);
            consecutivoFormateado = ObtenerConsecutivoFormateado(laInformacionDelCodigo);
        }

        private string ObtenerFechaCompletaComoTexto(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            return new FechaComoTexto(laInformacionDelCodigo).ComoTexto();
        }

        private string ObtenerClienteFormateado(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            // TODO: 2 PUNTOS
            return laInformacionDelCodigo.cliente.PadLeft(3, '0');
        }

        private string ObtenerSistemaFormateado(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            // TODO: 2 PUNTOS
            return laInformacionDelCodigo.sistema.PadLeft(2, '0');
        }

        private string ObtenerConsecutivoFormateado(InformacionDelCodigoDeReferencia laInformacionDelCodigo)
        {
            // TODO: 2 PUNTOS
            return laInformacionDelCodigo.consecutivo.PadLeft(12, '0');
        }

        public string ComoTexto()
        {
            return fechaCompletaComoTexto + clienteFormateado + sistemaFormateado + consecutivoFormateado;
        }
    }
}
