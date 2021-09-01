namespace Febraban240
{
    class RegistroDetalheA : RegistroDetalhe
    {
        public Campo TipoMovimento { get; set; }
        public Campo CodigoInstrucaoParaMovimento { get; set; }
        public Campo CodigoCamaraCentralizadora { get; set; }
        public Campo CodigoBancoFavorecido { get; set; }
        public Campo AgenciaMantenedoraContaFavorecido { get; set; }
        public Campo DigitoVerificadorAgencia { get; set; }
        public Campo NumeroContaCorrente { get; set; }
        public Campo DigitoVerificadorConta { get; set; }
        public Campo DigitoVerificadorAgenciaConta { get; set; }
        public Campo NomeFavorecido { get; set; }
        public Campo NumeroDocumentoAtribuidoPelaEmpresa { get; set; }
        public Campo DataPagamento { get; set; }
        public Campo TipoMoeda { get; set; }
        public Campo QuantidadeMoeda { get; set; }
        public Campo ValorPagamento { get; set; }
        public Campo NumeroDocumentoAtribuidoPeloBanco { get; set; }
        public Campo DataRealEfetivacaoPagamento { get; set; }
        public Campo ValorRealEfetivacaoPagamento { get; set; }
        public Campo OutrasInformacoes { get; set; }
        public Campo ComplementoTipoServico { get; set; }
        public Campo CodigoFinalidadeTed { get; set; }
        public Campo ComplementoFinalidadePagamento { get; set; }
        public Campo UsoExclusivoFebrabanCnab { get; set; }
        public Campo AvisoFavorecido { get; set; }
        public Campo CodigosOcorrenciasParaRetorno { get; set; }

        public RegistroDetalheA()
        {
            TipoMovimento = new CampoNumerico(15, 15, 0, "*G060");
            CodigoInstrucaoParaMovimento = new CampoNumerico(16, 17, 0, "G061");
            CodigoCamaraCentralizadora = new CampoNumerico(18, 20, 0, "*P001");
            CodigoBancoFavorecido = new CampoNumerico(21, 23, 0, "P002");
            AgenciaMantenedoraContaFavorecido = new CampoNumerico(24, 28, 0, "*G008");
            DigitoVerificadorAgencia = new CampoAlfanumerico(29, 29, "*G009");
            NumeroContaCorrente = new CampoNumerico(30, 41, 0, "*G010");
            DigitoVerificadorConta = new CampoAlfanumerico(42, 42, "*G011");
            DigitoVerificadorAgenciaConta = new CampoAlfanumerico(43, 43, "*G012");
            NomeFavorecido = new CampoAlfanumerico(44, 73, "G013");
            NumeroDocumentoAtribuidoPelaEmpresa = new CampoAlfanumerico(74, 93, "G064");
            DataPagamento = new CampoNumerico(94, 101, 0, "P009");
            TipoMoeda = new CampoAlfanumerico(102, 104, "*G040");
            QuantidadeMoeda = new CampoNumerico(105, 119, 5, "G041");
            ValorPagamento = new CampoNumerico(120, 134, 2, "P010");
            NumeroDocumentoAtribuidoPeloBanco = new CampoAlfanumerico(135, 154, "*G043");
            DataRealEfetivacaoPagamento = new CampoNumerico(155, 162, 0, "P003");
            ValorRealEfetivacaoPagamento = new CampoNumerico(163, 177, 2, "P004");
            OutrasInformacoes = new CampoAlfanumerico(178, 217, "*G031");
            ComplementoTipoServico = new CampoAlfanumerico(218, 219, "*P005");
            CodigoFinalidadeTed = new CampoAlfanumerico(220, 224, "*P011");
            ComplementoFinalidadePagamento = new CampoAlfanumerico(225, 226, "P013");
            UsoExclusivoFebrabanCnab = new CampoAlfanumerico(227, 229, "G004");
            AvisoFavorecido = new CampoNumerico(230, 230, 0, "*P006");
            CodigosOcorrenciasParaRetorno = new CampoAlfanumerico(231, 240, "*G059");

            CodigoSegmentoRegistroDetalhe.Valor = "A";
        }
    }
}
