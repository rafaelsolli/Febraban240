namespace Febraban240
{
    class RegistroDetalheN3 : RegistroDetalheN
    {
        public Campo CodigoReceitaTributo { get; set; }
        public Campo TipoIdentificacaoContribuinte { get; set; }
        public Campo IdentificacaoContribuinte { get; set; }
        public Campo CodigoIdentificacaoTributo { get; set; }
        public Campo PeriodoApuracao { get; set; }
        public Campo ValorReceitaBrutaAcumulada { get; set; }
        public Campo PercentualSobreReceitaBrutaAcumulada { get; set; }
        public Campo ValorPrincipal { get; set; }
        public Campo ValorMulta { get; set; }
        public Campo ValorJurosEncargos { get; set; }
        public Campo UsoExclusivoFebrabanCnab { get; set; }

        public RegistroDetalheN3()
        {
            CodigoReceitaTributo = new CampoAlfanumerico(111, 116, "N002");
            TipoIdentificacaoContribuinte = new CampoNumerico(117, 118, 0, "N003");
            IdentificacaoContribuinte = new CampoNumerico(119, 132, 0, "N004");
            CodigoIdentificacaoTributo = new CampoAlfanumerico(133, 134, "N005");
            PeriodoApuracao = new CampoNumerico(135, 142, 0, "N006");
            ValorReceitaBrutaAcumulada = new CampoNumerico(143, 157, 2, "N010");
            PercentualSobreReceitaBrutaAcumulada = new CampoNumerico(158, 164, 2, "N011");
            ValorPrincipal = new CampoNumerico(165, 179, 2, "G042");
            ValorMulta = new CampoNumerico(180, 194, 2, "G048");
            ValorJurosEncargos = new CampoNumerico(195, 209, 2, "G047");
            UsoExclusivoFebrabanCnab = new CampoAlfanumerico(210, 230, "G004");

            CodigoReceitaTributo.Valor = "6106";
        }
    }
}
