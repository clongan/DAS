using System;
using Ccharpentierl905.Negocio.ConFunciones.Calculos;

namespace Ccharpentierl905.Negocio.ConFunciones.CodigosDeReferencia
{
    public class CodigosDeReferencia
    {
        public static string GenerarCodigoDeReferencia (DateTime fecha, string cliente, 
            string sistema, string consecutivo)
        {
            return ObtengaCodigoDeReferencia(fecha, ref cliente, ref sistema, ref consecutivo);
        }

        private static string ObtengaCodigoDeReferencia(DateTime fecha, ref string cliente, ref string sistema, ref string consecutivo)
        {
            string codigoDeReferenciaSinVerificador = ObtengaCodigoDeReferenciaSinVerificador(fecha, ref cliente, ref sistema, ref consecutivo);
            int verificador = CalculoDeDigitoVerificador.CalculeElDigitoVerificador(codigoDeReferenciaSinVerificador);

            return ConcatenarCodigoDeReferencia(codigoDeReferenciaSinVerificador, verificador);
        }

        private static string ConcatenarCodigoDeReferencia(string codigoDeReferenciaSinVerificador, int verificador)
        {
            return codigoDeReferenciaSinVerificador + verificador;
        }

        private static string ObtengaCodigoDeReferenciaSinVerificador(DateTime fecha, ref string cliente, ref string sistema, ref string consecutivo)
        {
            string fechaCompletaComoTexto = FormatearFechaATexto(fecha);

            //Dar a cliente/sistema/consecutivo relleno de 0 a 3/2/12 espacios
            cliente = cliente.PadLeft(3, '0');
            sistema = sistema.PadLeft(2, '0');
            consecutivo = consecutivo.PadLeft(12, '0');

            return ConcatenarCodigoDeReferenciaSinVerificador(cliente, sistema, consecutivo, fechaCompletaComoTexto);
        }

        private static string ConcatenarCodigoDeReferenciaSinVerificador(string cliente, string sistema, string consecutivo, string fechaCompletaComoTexto)
        {
            return fechaCompletaComoTexto + cliente + sistema + consecutivo;
        }

        private static string FormatearFechaATexto(DateTime fecha)
        {
            int dia = fecha.Day;
            int mes = fecha.Month;
            int año = fecha.Year;

            //Convertir fechas en String, y darles relleno con 0 a 2 y 4 espacios
            string diaEnTexto = dia.ToString();
            string mesEnTexto = mes.ToString();
            string añoEnTexto = año.ToString();

            string diaEnTextoRellenoConCero = diaEnTexto.PadLeft(2, '0');
            string mesEnTextoRellenoConCero = mesEnTexto.PadLeft(2, '0');
            string añoEnTextoRellenoConCero = añoEnTexto.PadLeft(4, '0');

            return ConcatenarFechaATexto(diaEnTextoRellenoConCero, mesEnTextoRellenoConCero, añoEnTextoRellenoConCero);
        }

        private static string ConcatenarFechaATexto(string diaEnTextoRellenoConCero, string mesEnTextoRellenoConCero, string añoEnTextoRellenoConCero)
        {
            return añoEnTextoRellenoConCero + mesEnTextoRellenoConCero + diaEnTextoRellenoConCero;
        }
    }
}
