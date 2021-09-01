namespace Febraban240
{
    class RegistroDetalheN7 : RegistroDetalheN
    {
        public Campo CodigoReceitaTributo { get; set; }
        public Campo TipoIdentificacaoContribuinte { get; set; }
        public Campo IdentificacaoContribuinte { get; set; }
        public Campo CodigoIdentificacaoTributo { get; set; }
        public Campo AnoBase { get; set; }
        public Campo CodigoRenavam { get; set; }
        public Campo UnidadeFederacao { get; set; }
        public Campo CodigoMunicipio { get; set; }
        public Campo PlacaVeiculo { get; set; }
        public Campo OpcaoPagamento { get; set; }
        public Campo OpcaoRetirada { get; set; }
        public Campo NovoCodigoRenavam { get; set; }
        public Campo UsoExclusivoFebrabanCnab { get; set; }

        public RegistroDetalheN7()
        {
            CodigoReceitaTributo = new CampoAlfanumerico(111, 116, "N002");
            TipoIdentificacaoContribuinte = new CampoNumerico(117, 118, 0, "N003");
            IdentificacaoContribuinte = new CampoNumerico(119, 132, 0, "N004");
            CodigoIdentificacaoTributo = new CampoAlfanumerico(133, 134, "N005");
            AnoBase = new CampoNumerico(135, 138, 0, "N015");
            CodigoRenavam = new CampoNumerico(139, 147, 0, "N016");
            UnidadeFederacao = new CampoAlfanumerico(148, 149, "G036");
            CodigoMunicipio = new CampoNumerico(150, 154, 0, "N017");
            PlacaVeiculo = new CampoAlfanumerico(155, 161, "N018");
            OpcaoPagamento = new CampoAlfanumerico(162, 162, "N019");
            OpcaoRetirada = new CampoAlfanumerico(163, 163, "N020");
            NovoCodigoRenavam = new CampoNumerico(164, 175, 0, "N016");
            UsoExclusivoFebrabanCnab = new CampoAlfanumerico(176, 230, "G004");

            OpcaoPagamento.Valor = "5";
        }
    }
}
