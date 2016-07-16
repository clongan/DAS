namespace CodigosDeReferencia.ConObjetos
{
    public class MesComoTexto
    {
        private string mesComoTexto;
        private string MesFormateado;

        public MesComoTexto(int Mes)
        {
            mesComoTexto = ObtengaMesComoTexto(Mes);
            MesFormateado = FormateeMes(mesComoTexto);
        }

        public string ComoTexto()
        {
            return MesFormateado;
        }

        private string ObtengaMesComoTexto(int mes)
        {
            return mes.ToString();
        }

        private string FormateeMes(string mesComoTexto)
        {
            return mesComoTexto.PadLeft(2, '0');
        }

    }
}
