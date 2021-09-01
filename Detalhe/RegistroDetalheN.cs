namespace Febraban240
{
    abstract class RegistroDetalheN : RegistroDetalhe
    {
        public Campo TipoMovimento { get; set; }
        public Campo CodigoInstrucaoMovimento { get; set; }
        public Campo NumeroDocumentoAtribuidoEmpresa { get; set; }
        public Campo NumeroDocumentoAtribuidoBanco { get; set; }
        public Campo NomeContribuinte { get; set; }
        public Campo DataPagamento { get; set; }
        public Campo ValorTotalPagamento { get; set; }
        public Campo CodigosOcorrenciasParaRetorno { get; set; }

        protected RegistroDetalheN()
        {
            TipoMovimento = new CampoNumerico(15, 15, 0, "G060");
            CodigoInstrucaoMovimento = new CampoNumerico(16, 17, 0, "G061");
            NumeroDocumentoAtribuidoEmpresa = new CampoAlfanumerico(18, 37, "G064");
            NumeroDocumentoAtribuidoBanco = new CampoAlfanumerico(38, 57, "G043");
            NomeContribuinte = new CampoAlfanumerico(58, 87, "G013");
            DataPagamento = new CampoNumerico(88, 95, 0, "P009");
            ValorTotalPagamento = new CampoNumerico(96, 110, 2, "P010");
            CodigosOcorrenciasParaRetorno = new CampoAlfanumerico(231, 240, "*G059");

            CodigoSegmentoRegistroDetalhe.Valor = "N";
        }
    }
}
