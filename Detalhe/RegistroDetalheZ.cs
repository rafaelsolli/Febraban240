namespace Febraban240
{
    class RegistroDetalheZ : RegistroDetalhe
    {
        public Campo AutenticacaoAtenderLegislacao { get; set; }
        public Campo AutenticacaoBancariaProtocolo { get; set; }
        public Campo UsoExclusivoFebrabanCnab { get; set; }
        public Campo CodigosOcorrenciasParaRetorno { get; set; }

        public RegistroDetalheZ()
        {
            AutenticacaoAtenderLegislacao = new CampoAlfanumerico(15, 78, "Z001");
            AutenticacaoBancariaProtocolo = new CampoAlfanumerico(79, 103, "Z002");
            UsoExclusivoFebrabanCnab = new CampoAlfanumerico(104, 230, "G004");
            CodigosOcorrenciasParaRetorno = new CampoAlfanumerico(231, 240, "*G059");

            CodigoSegmentoRegistroDetalhe.Valor = "Z";
        }
    }
}
