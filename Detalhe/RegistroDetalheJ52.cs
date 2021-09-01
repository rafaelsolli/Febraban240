namespace Febraban240
{
    class RegistroDetalheJ52 : RegistroDetalhe
    {
        public Campo UsoExclusivoFebrabanCnab1 { get; set; }
        public Campo CodigoMovimentoRemessa { get; set; }
        public Campo IdentificacaoRegistroOpcional { get; set; }
        public Campo TipoInscricaoPagador { get; set; }
        public Campo NumeroInscricaoPagador { get; set; }
        public Campo NomePagador { get; set; }
        public Campo TipoInscricaoBeneficiario { get; set; }
        public Campo NumeroInscricaoBeneficiario { get; set; }
        public Campo NomeBeneficiario { get; set; }
        public Campo TipoInscricaoPagadorr { get; set; }
        public Campo NumeroInscricaoPagadorr { get; set; }
        public Campo NomePagadorr { get; set; }
        public Campo UsoExclusivoFebrabanCnab2 { get; set; }

        public RegistroDetalheJ52()
        {
            UsoExclusivoFebrabanCnab1 = new CampoAlfanumerico(15, 15, "G004");
            CodigoMovimentoRemessa = new CampoNumerico(16, 17, 0, "*C004");
            IdentificacaoRegistroOpcional = new CampoNumerico(18, 19, 0, "G067");
            TipoInscricaoPagador = new CampoNumerico(20, 20, 0, "*G005");
            NumeroInscricaoPagador = new CampoNumerico(21, 35, 0, "*G006");
            NomePagador = new CampoAlfanumerico(36, 75, "G013");
            TipoInscricaoBeneficiario = new CampoNumerico(76, 76, 0, "*G005");
            NumeroInscricaoBeneficiario = new CampoNumerico(77, 91, 0, "*G006");
            NomeBeneficiario = new CampoAlfanumerico(92, 131, "G013");
            TipoInscricaoPagadorr = new CampoNumerico(132, 132, 0, "*G005");
            NumeroInscricaoPagadorr = new CampoNumerico(133, 147, 0, "*G006");
            NomePagadorr = new CampoAlfanumerico(148, 187, "G013");
            UsoExclusivoFebrabanCnab2 = new CampoAlfanumerico(188, 240, "G004");

            CodigoSegmentoRegistroDetalhe.Valor = "J";
            IdentificacaoRegistroOpcional.Valor = "52";
        }
    }
}
