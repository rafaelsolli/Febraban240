namespace Febraban240
{
    class RegistroDetalheJ52Pix : RegistroDetalhe
    {
        public Campo UsoExclusivoFebrabanCnab1 { get; set; }
        public Campo CodigoMovimentoRemessa { get; set; }
        public Campo IdentificacaoRegistroOpcional { get; set; }
        public Campo TipoInscricaoDevedor { get; set; }
        public Campo NumeroInscricaoDevedor { get; set; }
        public Campo NomeDevedor { get; set; }
        public Campo TipoInscricaoFavorecido { get; set; }
        public Campo NumeroInscricaoFavorecido { get; set; }
        public Campo NomeFavorecido { get; set; }
        public Campo UrlChaveEnderecamento { get; set; }
        public Campo CodigoIdentificacaoQrCode { get; set; }

        public RegistroDetalheJ52Pix()
        {
            UsoExclusivoFebrabanCnab1 = new CampoAlfanumerico(15, 15, "G004");
            CodigoMovimentoRemessa = new CampoNumerico(16, 17, 0, "*C004");
            IdentificacaoRegistroOpcional = new CampoNumerico(18, 19, 0, "G067");
            TipoInscricaoDevedor = new CampoNumerico(20, 20, 0, "*G005");
            NumeroInscricaoDevedor = new CampoNumerico(21, 35, 0, "*G006");
            NomeDevedor = new CampoAlfanumerico(36, 75, "G013");
            TipoInscricaoFavorecido = new CampoNumerico(76, 76, 0, "*G005");
            NumeroInscricaoFavorecido = new CampoNumerico(77, 91, 0, "*G006");
            NomeFavorecido = new CampoAlfanumerico(92, 131, "G013");
            UrlChaveEnderecamento = new CampoAlfanumerico(132, 210, "G102");
            CodigoIdentificacaoQrCode = new CampoAlfanumerico(211, 240, "G102");

            CodigoSegmentoRegistroDetalhe.Valor = "J";
            IdentificacaoRegistroOpcional.Valor = "52";
        }
    }
}
