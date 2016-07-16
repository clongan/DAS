namespace CodigosDeReferencia.ConObjetos
{
    public class DiaComoTexto
    {
        private string diaComoTexto;
        private string diaFormateado;

        public DiaComoTexto(int dia)
        {
            diaComoTexto = ObtengaDiaComoTexto(dia);
            diaFormateado = FormateeDia(diaComoTexto);
        }

        public string ComoTexto()
        {
            return diaFormateado;
        }

        private string ObtengaDiaComoTexto(int dia)
        {
            return dia.ToString();
        }

        private string FormateeDia(string diaComoTexto)
        {
            return diaComoTexto.PadLeft(2, '0');
        }

    }
}
