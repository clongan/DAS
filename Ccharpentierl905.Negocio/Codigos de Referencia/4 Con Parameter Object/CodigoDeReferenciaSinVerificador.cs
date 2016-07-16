namespace CodigosDeReferencia.ConParameterObject
{
    public class CodigoDeReferenciaSinVerificador
    {
        string fechaCompletaComoTexto;
        string clienteFormateado;
        string sistemaFormateado;
        string consecutivoFormateado;

        public CodigoDeReferenciaSinVerificador(InformacionDelCodigoDeReferencia laInformacion)
        {
            fechaCompletaComoTexto = ObtenerFechaCompletaComoTexto(laInformacion);
            clienteFormateado = ObtenerClienteFormateado(laInformacion);
            sistemaFormateado = ObtenerSistemaFormateado(laInformacion);
            consecutivoFormateado = ObtenerConsecutivoFormateado(laInformacion);
        }

        private string ObtenerFechaCompletaComoTexto(InformacionDelCodigoDeReferencia laInformacion)
        {
            return new FechaComoTexto(laInformacion).ComoTexto();
        }

        private string ObtenerClienteFormateado(InformacionDelCodigoDeReferencia laInformacion)
        {
            // TODO: 2 PUNTOS 
            return laInformacion.cliente.PadLeft(3, '0');
        }

        private string ObtenerSistemaFormateado(InformacionDelCodigoDeReferencia laInformacion)
        {
            // TODO: 2 PUNTOS 
            return laInformacion.sistema.PadLeft(2, '0');
        }

        private string ObtenerConsecutivoFormateado(InformacionDelCodigoDeReferencia laInformacion)
        {
            // TODO: 2 PUNTOS 
            return laInformacion.consecutivo.PadLeft(12, '0');
        }

        public string ComoTexto()
        {
            return fechaCompletaComoTexto + clienteFormateado + sistemaFormateado + consecutivoFormateado;
        }
    }
}
