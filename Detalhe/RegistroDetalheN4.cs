namespace Febraban240
{
    class RegistroDetalheN4 : RegistroDetalheN
    {
        public Campo CodigoReceitaTributo { get; set; }
        public Campo TipoIdentificacaoContribuinte { get; set; }
        public Campo IdentificacaoContribuinte { get; set; }
        public Campo CodigoIdentificaccaoTributo { get; set; }
        public Campo DataVencimento { get; set; }
        public Campo InscricaoEstadualCodigoMunicipioNumeroDeclaracao { get; set; }
        public Campo DividaAtivaNumeroEtiqueta { get; set; }
        public Campo PeriodoReferencia { get; set; }
        public Campo NumeroParcelaNotificacao { get; set; }
        public Campo ValorReceita { get; set; }
        public Campo ValorJurosEncargos { get; set; }
        public Campo ValorMulta { get; set; }
        public Campo UsoExclusivoFebrabanCnab { get; set; }

        public RegistroDetalheN4()
        {
            CodigoReceitaTributo = new CampoAlfanumerico(111, 116, "N002");
            TipoIdentificacaoContribuinte = new CampoNumerico(117, 118, 0, "N003");
            IdentificacaoContribuinte = new CampoNumerico(119, 132, 0, "N004");
            CodigoIdentificaccaoTributo = new CampoAlfanumerico(133, 134, "N005");
            DataVencimento = new CampoNumerico(135, 142, 0, "G044");
            InscricaoEstadualCodigoMunicipioNumeroDeclaracao = new CampoNumerico(143, 154, 0, "N012");
            DividaAtivaNumeroEtiqueta = new CampoNumerico(155, 167, 0, "N013");
            PeriodoReferencia = new CampoNumerico(168, 173, 0, "N006");
            NumeroParcelaNotificacao = new CampoNumerico(174, 186, 0, "N014");
            ValorReceita = new CampoNumerico(187, 201, 2, "G042");
            ValorJurosEncargos = new CampoNumerico(202, 215, 2, "G047");
            ValorMulta = new CampoNumerico(216, 229, 2, "G048");
            UsoExclusivoFebrabanCnab = new CampoAlfanumerico(230, 230, "G004");
        }
    }
}
