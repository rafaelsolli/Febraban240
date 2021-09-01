namespace Febraban240
{
    class RegistroDetalheJ : RegistroDetalhe
    {
        public Campo TipoMovimento { get; set; }
        public Campo CodigoInstrucaoParaMovimento { get; set; }
        public Campo CodicoBarras { get; set; }
        public Campo NomeBeneficiario { get; set; }
        public Campo DataVencimentoNominal { get; set; }
        public Campo ValorTituloNominal { get; set; }
        public Campo ValorDescontoAbatimento { get; set; }
        public Campo ValorMoraMulta { get; set; }
        public Campo DataPagamento { get; set; }
        public Campo ValorPagamento { get; set; }
        public Campo QuantidadeMoeda { get; set; }
        public Campo NumeroDocumentoAtribuidoEmpresa { get; set; }
        public Campo NumeroDocumentoAtribuidoBanco { get; set; }
        public Campo CodigoMoeda { get; set; }
        public Campo UsoExclusivoFebrabanCnab { get; set; }
        public Campo CodigosOcorrenciasParaRetorno { get; set; }

        public RegistroDetalheJ()
        {
            TipoMovimento = new CampoNumerico(15, 15, 0, "*G060");
            CodigoInstrucaoParaMovimento = new CampoNumerico(16, 17, 0, "G061");
            CodicoBarras = new CampoNumerico(18, 61, 0, "*G063");
            NomeBeneficiario = new CampoAlfanumerico(62, 91, "G013");
            DataVencimentoNominal = new CampoNumerico(92, 99, 0, "G044");
            ValorTituloNominal = new CampoNumerico(100, 114, 2, "G042");
            ValorDescontoAbatimento = new CampoNumerico(115, 129, 2, "L002");
            ValorMoraMulta = new CampoNumerico(130, 144, 2, "L003");
            DataPagamento = new CampoNumerico(145, 152, 0, "P009");
            ValorPagamento = new CampoNumerico(153, 167, 2, "P010");
            QuantidadeMoeda = new CampoNumerico(168, 182, 5, "G041");
            NumeroDocumentoAtribuidoEmpresa = new CampoAlfanumerico(183, 202, "G064");
            NumeroDocumentoAtribuidoBanco = new CampoAlfanumerico(203, 222, "*G043");
            CodigoMoeda = new CampoNumerico(223, 224, 0, "*G065");
            UsoExclusivoFebrabanCnab = new CampoAlfanumerico(225, 230, "G004");
            CodigosOcorrenciasParaRetorno = new CampoAlfanumerico(231, 240, "*G059");

            CodigoSegmentoRegistroDetalhe.Valor = "J";
        }
    }
}
