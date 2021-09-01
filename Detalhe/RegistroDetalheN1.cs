namespace Febraban240
{
    class RegistroDetalheN1 : RegistroDetalheN
    {
        public Campo CodigoReceitaTributo { get; set; }
        public Campo TipoIdentificacaoContribuinte { get; set; }
        public Campo IdentificacaoContribuinte { get; set; }
        public Campo CodigoIdentificacaoTributo { get; set; }
        public Campo MesAnoCompetencia { get; set; }
        public Campo ValorPrevistoPagamentoInss { get; set; }
        public Campo ValorOutrasEntidades { get; set; }
        public Campo AtualizacaoMonetaria { get; set; }
        public Campo UsoExclusivoFebrabanCnab { get; set; }

        public RegistroDetalheN1()
        {
            CodigoReceitaTributo = new CampoAlfanumerico(111, 116, "N002");
            TipoIdentificacaoContribuinte = new CampoNumerico(117, 118, 0, "N003");
            IdentificacaoContribuinte = new CampoNumerico(119, 132, 0, "N004");
            CodigoIdentificacaoTributo = new CampoAlfanumerico(133, 134, "N005");
            MesAnoCompetencia = new CampoNumerico(135, 140, 0, "N006");
            ValorPrevistoPagamentoInss = new CampoNumerico(141, 155, 2, "G055");
            ValorOutrasEntidades = new CampoNumerico(156, 170, 2, "G054");
            AtualizacaoMonetaria = new CampoNumerico(171, 185, 2, "N007");
            UsoExclusivoFebrabanCnab = new CampoAlfanumerico(186, 230, "G004");
        }
    }
}
