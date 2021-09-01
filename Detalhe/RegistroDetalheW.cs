namespace Febraban240
{
    abstract class RegistroDetalheW : RegistroDetalhe
    {
        public Campo NumeroSequencialRegistroComplementar { get; set; }
        public Campo IdentificacaoUsoInformacoes { get; set; }
        public Campo InformacaoComplementar1 { get; set; }
        public Campo InformacaoComplementar2 { get; set; }
        public Campo IdentificacaoTributo { get; set; }
        public Campo UsoExclusivoFebrabanCnab1 { get; set; }
        public Campo CodigoOcorrenciasParaRetorno { get; set; }

        protected RegistroDetalheW()
        {
            NumeroSequencialRegistroComplementar = new CampoNumerico(15, 15, 0, "N023");
            IdentificacaoUsoInformacoes = new CampoAlfanumerico(16, 16, "N024");
            InformacaoComplementar1 = new CampoAlfanumerico(17, 96, "N025");
            InformacaoComplementar2 = new CampoAlfanumerico(97, 176, "N025");
            IdentificacaoTributo = new CampoAlfanumerico(177, 178, "N027");
            UsoExclusivoFebrabanCnab1 = new CampoAlfanumerico(229, 230, "G0004");
            CodigoOcorrenciasParaRetorno = new CampoAlfanumerico(231, 240, "*G059");

            CodigoSegmentoRegistroDetalhe.Valor = "W";
            CodigoOcorrenciasParaRetorno.Valor = "G059";
        }
    }
}
