using System;
using Ccharpentierl905.Negocio.ConFunciones.Calculos;

namespace Ccharpentierl905.Negocio.ConFunciones.CodigosDeReferencia
{
    public class CodigosDeReferencia
    {
        public static string GenerarCodigoDeReferencia(DateTime fecha, string cliente,
            string sistema, string consecutivo)
        {
            string codigoDeReferenciaSinVerificador = ObtenerCodigoDeReferenciaSinVerificador(fecha, cliente, sistema, consecutivo);
            int verificador = CalculoDeDigitoVerificador.CalculeElDigitoVerificador(codigoDeReferenciaSinVerificador);

            return ObtenerCodigoDeReferencia(codigoDeReferenciaSinVerificador, verificador);
        }

        private static string ObtenerCodigoDeReferenciaSinVerificador(DateTime fecha, string cliente, string sistema, string consecutivo)
        {
            string fechaCompletaComoTexto = FormatearFechaComoTexto(fecha);
            string clienteFormateado = RellenarClienteConCeros(cliente);
            string sistemaFormateado = RellenarSistemaConCeros(sistema);
            string consecutivoFormateado = RellenarConsecutivoConCeros(consecutivo);

            return FormateeCodigodeReferenciaSinVerificador(fechaCompletaComoTexto, clienteFormateado, sistemaFormateado, consecutivoFormateado);
        }

        private static string FormatearFechaComoTexto(DateTime fecha)
        {
            int dia = fecha.Day;
            string diaEnTexto = dia.ToString();
            string diaEnTextoRellenoConCero = diaEnTexto.PadLeft(2, '0');

            int mes = fecha.Month;
            string mesEnTexto = mes.ToString();
            string mesEnTextoRellenoConCero = mesEnTexto.PadLeft(2, '0');

            int año = fecha.Year;
            string añoEnTexto = año.ToString();

            return ObtengaFechaComoTexto(diaEnTextoRellenoConCero, mesEnTextoRellenoConCero, añoEnTexto);
        }

        private static string ObtengaFechaComoTexto(string diaEnTextoRellenoConCero, string mesEnTextoRellenoConCero, string añoEnTexto)
        {
            return añoEnTexto + mesEnTextoRellenoConCero + diaEnTextoRellenoConCero;
        }

        private static string RellenarClienteConCeros(string cliente)
        {
            return cliente.PadLeft(3, '0');
        }

        private static string RellenarSistemaConCeros(string sistema)
        {
            return sistema.PadLeft(2, '0');
        }

        private static string RellenarConsecutivoConCeros(string consecutivo)
        {
            return consecutivo.PadLeft(12, '0');
        }

        private static string FormateeCodigodeReferenciaSinVerificador(string fechaCompletaComoTexto, string clienteFormateado, string sistemaFormateado, string consecutivoFormateado)
        {
            return fechaCompletaComoTexto + clienteFormateado + sistemaFormateado + consecutivoFormateado;
        }

        private static string ObtenerCodigoDeReferencia(string codigoDeReferenciaSinVerificador, int verificador)
        {
            return codigoDeReferenciaSinVerificador + verificador;
        }
    }
}
