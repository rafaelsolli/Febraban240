namespace Febraban240
{
    class RegistroTrailerArquivo : RegistroTrailer
    {
        public Campo QuantidadeLotesArquivo { get; set; }
        public Campo QuantidadeRegistrosArquivo { get; set; }
        public Campo QuantidadeContasParaConciliacaoLotes { get; set; }
        public Campo UsoExclusivoFebrabanCnab2 { get; set; }

        public RegistroTrailerArquivo()
        {
            QuantidadeLotesArquivo = new CampoNumerico(18, 23, 0, "G049");
            QuantidadeRegistrosArquivo = new CampoNumerico(24, 29, 0, "G056");
            QuantidadeContasParaConciliacaoLotes = new CampoNumerico(30, 35, 0, "*G037");
            UsoExclusivoFebrabanCnab2 = new CampoAlfanumerico(36, 240, "G004");

            LoteServico.Valor = "9999";
            LoteServico.Valor = "9";
        }
    }
}
