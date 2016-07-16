using System;

namespace ValidacionDeDatos.ConParameterObject
{
    public class ValidacionDeDato
    {
        public static bool ValidarDatos(LaInformacionDeValidacion laInformacion)
        {
            return new DeterminarValidezDeDatos(laInformacion).DeterminarSiEsValido();
        }
    }
}
