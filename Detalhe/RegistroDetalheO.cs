namespace Febraban240
{
    class RegistroDetalheO : RegistroDetalhe
    {
        public Campo TipoMovimento { get; set; }
        public Campo CodigoInstrucaoMovimento { get; set; }
        public Campo CodigoBarras { get; set; }
        public Campo NomeConcessionariaOrgaoPublico { get; set; }
        public Campo DataVencimentoNominal { get; set; }
        public Campo DataPagamento { get; set; }
        public Campo ValorPagamento { get; set; }
        public Campo NumeroDocumentoAtribuidoEmpresa { get; set; }
        public Campo NumeroDocumentoAtribuidoBanco { get; set; }
        public Campo UsoExclusivoFebrabanCnab { get; set; }
        public Campo CodigosOcorrenciasParaRetorno { get; set; }

        public RegistroDetalheO()
        {
            TipoMovimento = new CampoNumerico(15, 15, 0, "G060");
            CodigoInstrucaoMovimento = new CampoNumerico(16, 17, 0, "G061");
            CodigoBarras = new CampoAlfanumerico(18, 61, "N001");
            NomeConcessionariaOrgaoPublico = new CampoAlfanumerico(62, 91, "G013");
            DataVencimentoNominal = new CampoNumerico(92, 99, 0, "G044");
            DataPagamento = new CampoNumerico(100, 107, 0, "P009");
            ValorPagamento = new CampoNumerico(108, 122, 2, "P004");
            NumeroDocumentoAtribuidoEmpresa = new CampoAlfanumerico(123, 142, "G064");
            NumeroDocumentoAtribuidoBanco = new CampoAlfanumerico(143, 162, "G043");
            UsoExclusivoFebrabanCnab = new CampoAlfanumerico(163, 230, "G004");
            CodigosOcorrenciasParaRetorno = new CampoAlfanumerico(231, 240, "*G059");

            CodigoSegmentoRegistroDetalhe.Valor = "O";
        }
    }
}
