namespace Febraban240
{
    class RegistroHeaderLote012 : RegistroHeaderLote
    {
        public Campo IndicativoFormaPagamentoCompromisso { get; set; }

        public RegistroHeaderLote012()
        {
            IndicativoFormaPagamentoCompromisso = new CampoNumerico(223, 224, 0, "P014");
            UsoExclusivoFebrabanCnab2 = new CampoAlfanumerico(225, 230, "G004");
            CodigosOcorrenciasParaRetorno = new CampoAlfanumerico(231, 240, "*G059");

            TipoOperacao.Valor = "C";
            NumeroVersaoLayoutLote.Valor = "012";
        }
    }
}
