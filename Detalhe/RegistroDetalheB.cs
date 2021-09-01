namespace Febraban240
{
    class RegistroDetalheB : RegistroDetalhe
    {
        public Campo FormaIniciacao { get; set; }
        public Campo TipoInscricaoFavorecido { get; set; }
        public Campo NumeroInscricaoFavorecido { get; set; }
        public Campo Informacao10 { get; set; }
        public Campo Informacao11 { get; set; }
        public Campo Informacao12 { get; set; }
        public Campo UsoExclusivoSiape { get; set; }
        public Campo CodigoIspb { get; set; }

        public RegistroDetalheB()
        {
            FormaIniciacao = new CampoAlfanumerico(15, 17, "G100");
            TipoInscricaoFavorecido = new CampoNumerico(18, 18, 0, "*G005");
            NumeroInscricaoFavorecido = new CampoNumerico(19, 32, 0, "*G006");
            Informacao10 = new CampoAlfanumerico(33, 67, "G101");
            Informacao11 = new CampoAlfanumerico(68, 127, "G101");
            Informacao12 = new CampoAlfanumerico(128, 226, "G101");
            UsoExclusivoSiape = new CampoNumerico(227, 232, 0, "P012");
            CodigoIspb = new CampoNumerico(233, 240, 0, "P015");

            CodigoSegmentoRegistroDetalhe.Valor = "B";
        }
    }
}
