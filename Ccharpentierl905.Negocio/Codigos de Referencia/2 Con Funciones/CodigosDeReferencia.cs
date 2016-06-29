using System;
using Ccharpentierl905.Negocio.ConFunciones.Calculos;

namespace ConFunciones
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
            string diaEnTextoRellenoConCero = ObtenerDiaEnTexto(fecha);
            string mesEnTextoRellenoConCero = ObtenerMesEnTexto(fecha);
            string añoEnTexto = ObtenerAñoEnTexto(fecha);

            return ObtengaFechaComoTexto(diaEnTextoRellenoConCero, mesEnTextoRellenoConCero, añoEnTexto);
        }

        private static string ObtenerDiaEnTexto(DateTime fecha)
        {
            string diaEnTexto = FormatearDiaATexto(fecha);
            return RellenarDiaConCeros(diaEnTexto);
        }

        private static string FormatearDiaATexto(DateTime fecha)
        {
            int dia = ExtraerDiaDeFecha(fecha);
            return ConvertirDiaATexto(dia);
        }

        private static int ExtraerDiaDeFecha(DateTime fecha)
        {
            return fecha.Day;
        }

        private static string ConvertirDiaATexto(int dia)
        {
            return dia.ToString();
        }

        private static string RellenarDiaConCeros(string diaEnTexto)
        {
            return diaEnTexto.PadLeft(2, '0');
        }

        private static string ObtenerMesEnTexto(DateTime fecha)
        {
            string mesEnTexto = FormatearMesATexto(fecha);
            return RellenarMesConCeros(mesEnTexto);
        }

        private static string FormatearMesATexto(DateTime fecha)
        {
            int mes = ExtraerMesDeFecha(fecha);
            return ConvertirMesATexto(mes);

        }

        private static int ExtraerMesDeFecha(DateTime fecha)
        {
            return fecha.Month;
        }

        private static string ConvertirMesATexto(int mes)
        {
            return mes.ToString();
        }

        private static string RellenarMesConCeros(string mesEnTexto)
        {
            return mesEnTexto.PadLeft(2, '0');
        }

        private static string ObtenerAñoEnTexto(DateTime fecha)
        {
            int año = ExtraerAñoDeFecha(fecha);
            return ConvertirAñoATexto(año);
        }

        private static int ExtraerAñoDeFecha(DateTime fecha)
        {
            return fecha.Year;
        }

        private static string ConvertirAñoATexto(int año)
        {
            return año.ToString();
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
