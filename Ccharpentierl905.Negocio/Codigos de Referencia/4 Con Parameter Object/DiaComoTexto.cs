namespace CodigosDeReferencia.ConParameterObject
{
    public class DiaComoTexto
    {
        private string diaComoTexto;

        public DiaComoTexto(int dia)
        {
            diaComoTexto = dia.ToString();
        }

        public string ComoTexto()
        {
            return FormateeDia(diaComoTexto); 
        }

        private string FormateeDia(string diaComoTexto)
        {
            return diaComoTexto.PadLeft(2, '0');
        }

    }
}
