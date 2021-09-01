namespace Febraban240
{
    abstract class RegistroHeaderLote : RegistroHeader
    {
        public Campo TipoOperacao { get; set; }
        public Campo TipoServico { get; set; }
        public Campo FormaLancamento { get; set; }
        public Campo NumeroVersaoLayoutLote { get; set; }
        public Campo UsoExclusivoFebrabanCnab1 { get; set; }
        public Campo Mensagem { get; set; }
        public Campo Logradouro { get; set; }
        public Campo Numero { get; set; }
        public Campo Complemento { get; set; }
        public Campo Cidade { get; set; }
        public Campo Cep { get; set; }
        public Campo ComplementoCep { get; set; }
        public Campo Estado { get; set; }
        public Campo UsoExclusivoFebrabanCnab2 { get; set; }
        public Campo CodigosOcorrenciasParaRetorno { get; set; }

        public RegistroHeaderLote()
        {
            TipoOperacao = new CampoAlfanumerico(9, 9, "*G028");
            TipoServico = new CampoNumerico(10, 11, 0, "*G025");
            FormaLancamento = new CampoNumerico(12, 13, 0, "*G029");
            NumeroVersaoLayoutLote = new CampoNumerico(14, 16, 0, "*G030");
            UsoExclusivoFebrabanCnab1 = new CampoAlfanumerico(17, 17, "G004");
            Mensagem = new CampoAlfanumerico(103, 142, "*G031");
            Logradouro = new CampoAlfanumerico(143, 172, "G032");
            Numero = new CampoAlfanumerico(173, 177, "G032");
            Complemento = new CampoAlfanumerico(178, 192, "G032");
            Cidade = new CampoAlfanumerico(193, 212, "G033");
            Cep = new CampoNumerico(213, 217, 0, "G034");
            ComplementoCep = new CampoAlfanumerico(218, 220, "G035");
            Estado = new CampoAlfanumerico(221, 222, "G036");

            TipoRegistro.Valor = "1";
        }
    }
}
