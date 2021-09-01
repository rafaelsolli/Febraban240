namespace Febraban240
{
    class RegistroDetalheN2 : RegistroDetalheN
    {
        public Campo CodigoReceitaTributo { get; set; }
        public Campo TipoIdentificacaoContribuinte { get; set; }
        public Campo IdentificacaoContribuinte { get; set; }
        public Campo CodigoIdentificacaoTributo { get; set; }
        public Campo PeriodoApuracao { get; set; }
        public Campo NumeroReferencia { get; set; }
        public Campo ValorPrincipal { get; set; }
        public Campo ValorMulta { get; set; }
        public Campo ValorJurosEncargos { get; set; }
        public Campo DataVencimento { get; set; }
        public Campo UsoExclusivoFebrabanCnab { get; set; }

        public RegistroDetalheN2()
        {
            CodigoReceitaTributo = new CampoAlfanumerico(111, 116, "N002");
            TipoIdentificacaoContribuinte = new CampoNumerico(117, 118, 0, "N003");
            IdentificacaoContribuinte = new CampoNumerico(119, 132, 0, "N004");
            CodigoIdentificacaoTributo = new CampoAlfanumerico(133, 134, "N005");
            PeriodoApuracao = new CampoNumerico(135, 142, 0, "N008");
            NumeroReferencia = new CampoNumerico(143, 159, 0, "N009");
            ValorPrincipal = new CampoNumerico(160, 174, 2, "G042");
            ValorMulta = new CampoNumerico(175, 189, 2, "G048");
            ValorJurosEncargos = new CampoNumerico(190, 204, 2, "G047");
            DataVencimento = new CampoNumerico(205, 212, 0, "G044");
            UsoExclusivoFebrabanCnab = new CampoAlfanumerico(213, 230, "G004");
        }
    }
}
