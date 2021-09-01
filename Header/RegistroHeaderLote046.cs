namespace Febraban240
{
    class RegistroHeaderLote046 : RegistroHeaderLote
    {
        public Campo IndicativoFormaPagamentoServico { get; set; }

        public RegistroHeaderLote046()
        {
            IndicativoFormaPagamentoServico = new CampoNumerico(223, 224, 0, "P014");
            UsoExclusivoFebrabanCnab2 = new CampoAlfanumerico(225, 230, "G004");
            CodigosOcorrenciasParaRetorno = new CampoAlfanumerico(231, 240, "*G059");

            TipoOperacao.Valor = "C";
            NumeroVersaoLayoutLote.Valor = "046";
        }
    }
}
