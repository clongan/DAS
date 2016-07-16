using System;
using ComoUnProcedimiento.Calculos;

namespace CodigosDeReferencia.ComoUnProcedimiento
{
    public class CalculosDeCodigosDeReferencia
    {
        public static string GenerarCodigoDeReferencia (DateTime fecha, string cliente, 
            string sistema, string consecutivo)
        {
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

            cliente = cliente.PadLeft(3,'0');
            sistema = sistema.PadLeft(2, '0');
            consecutivo = consecutivo.PadLeft(12, '0');

            string codigoDeReferenciaSinVerificador = fechaCompletaComoTexto + cliente + sistema + consecutivo;

            int verificador = CalculoDeDigitoVerificador.CalculeElDigitoVerificador(codigoDeReferenciaSinVerificador);

            return codigoDeReferenciaSinVerificador + verificador;
        }
    }
}
