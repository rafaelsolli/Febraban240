namespace Febraban240
{
    class RegistroDetalheN8 : RegistroDetalheN
    {
        public Campo CodigoReceitaTributo { get; set; }
        public Campo TipoIdentificacaoContribuinte { get; set; }
        public Campo IdentificacaoContribuinte { get; set; }
        public Campo InscricaoEstadualCodigoMunicipioNumeroDeclaracao { get; set; }
        public Campo NumeroDocumentoOrigem { get; set; }
        public Campo ValorPrincipal { get; set; }
        public Campo ValorAtualizacaoMonetaria { get; set; }
        public Campo ValorMora { get; set; }
        public Campo ValorMulta { get; set; }
        public Campo DataVencimento { get; set; }
        public Campo PeriodoReferenciaNumeroParcela { get; set; }

        public RegistroDetalheN8()
        {
            CodigoReceitaTributo = new CampoAlfanumerico(111, 116, "N002");
            TipoIdentificacaoContribuinte = new CampoNumerico(117, 118, 0, "N003");
            IdentificacaoContribuinte = new CampoNumerico(119, 132, 0, "N004");
            InscricaoEstadualCodigoMunicipioNumeroDeclaracao = new CampoAlfanumerico(133, 140, "N012");
            NumeroDocumentoOrigem = new CampoNumerico(141, 156, 0, "N022");
            ValorPrincipal = new CampoNumerico(157, 171, 2, "G042");
            ValorAtualizacaoMonetaria = new CampoNumerico(172, 186, 2, "N007");
            ValorMora = new CampoNumerico(187, 201, 2, "G047");
            ValorMulta = new CampoNumerico(202, 216, 2, "G048");
            DataVencimento = new CampoNumerico(217, 224, 0, "G044");
            PeriodoReferenciaNumeroParcela = new CampoNumerico(225, 230, 0, "N006");
        }
    }
}
