namespace Febraban240
{
    class RegistroHeaderArquivo : RegistroHeader
    {
        public Campo UsoExclusivoFebrabanCnab1 { get; set; }
        public Campo NomeBanco { get; set; }
        public Campo UsoExclusivoFebrabanCnab2 { get; set; }
        public Campo CodigoRemessaRetorno { get; set; }
        public Campo DataGeracaoArquivo { get; set; }
        public Campo HoraGeracaoArquivo { get; set; }
        public Campo NumeroSequencialArquivo { get; set; }
        public Campo NumeroVersaoLayoutArquivo { get; set; }
        public Campo DensidadeGravacaoArquivo { get; set; }
        public Campo UsoReservadoBanco { get; set; }
        public Campo UsoReservadoEmpresa { get; set; }
        public Campo UsoExclusivoFebrabanCnab3 { get; set; }

        public RegistroHeaderArquivo()
        {
            UsoExclusivoFebrabanCnab1 = new CampoAlfanumerico(9, 17, "G004");
            NomeBanco = new CampoAlfanumerico(103, 132, "G014");
            UsoExclusivoFebrabanCnab2 = new CampoAlfanumerico(133, 142, "G004");
            CodigoRemessaRetorno = new CampoNumerico(143, 143, 0, "G015");
            DataGeracaoArquivo = new CampoNumerico(144, 151, 0, "G016");
            HoraGeracaoArquivo = new CampoNumerico(152, 157, 0, "G017");
            NumeroSequencialArquivo = new CampoNumerico(158, 163, 0, "*G018");
            NumeroVersaoLayoutArquivo = new CampoNumerico(164, 166, 0, "*G019");
            DensidadeGravacaoArquivo = new CampoNumerico(167, 171, 0, "G020");
            UsoReservadoBanco = new CampoAlfanumerico(172, 191, "G021");
            UsoReservadoEmpresa = new CampoAlfanumerico(192, 211, "G022");
            UsoExclusivoFebrabanCnab3 = new CampoAlfanumerico(212, 240, "G004");

            LoteServico.Valor = "0000";
            TipoRegistro.Valor = "0";
            NumeroVersaoLayoutArquivo.Valor = "103";
        }
    }
}
