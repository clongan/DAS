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
            //Convertir fechas en String, y darles relleno con 0 a 2 y 4 espacios
            int dia = fecha.Day;
            string diaEnTexto = dia.ToString();
            string diaEnTextoRellenoConCero = diaEnTexto.PadLeft(2, '0');

            int mes = fecha.Month;
            string mesEnTexto = mes.ToString();
            string mesEnTextoRellenoConCero = mesEnTexto.PadLeft(2, '0');

            int año = fecha.Year;
            string añoEnTexto = año.ToString();
            string añoEnTextoRellenoConCero = añoEnTexto.PadLeft(4, '0');

            string fechaCompletaComoTexto = añoEnTextoRellenoConCero + mesEnTextoRellenoConCero + diaEnTextoRellenoConCero;

            //Dar a cliente/sistema/consecutivo relleno de 0 a 3/2/12 espacios
            cliente = cliente.PadLeft(3, '0');
            sistema = sistema.PadLeft(2, '0');
            consecutivo = consecutivo.PadLeft(12, '0');

            string codigoDeReferenciaSinVerificador = fechaCompletaComoTexto + cliente + sistema + consecutivo;

            return codigoDeReferenciaSinVerificador;
        }

        private static string ObtenerCodigoDeReferencia(string codigoDeReferenciaSinVerificador, int verificador)
        {
            return codigoDeReferenciaSinVerificador + verificador;
        }
    }
}
