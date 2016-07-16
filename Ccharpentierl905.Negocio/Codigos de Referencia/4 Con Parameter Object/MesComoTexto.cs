namespace CodigosDeReferencia.ConParameterObject
{
    public class MesComoTexto
    {
        private string mesComoTexto;

        public MesComoTexto(int mes)
        {
            mesComoTexto = mes.ToString();
        }

        public string ComoTexto()
        {
            return FormateeMes(mesComoTexto);
        }

        private string FormateeMes(string mesComoTexto)
        {
            return mesComoTexto.PadLeft(2, '0');
        }

    }
}
