namespace Febraban240
{
    class RegistroDetalheC : RegistroDetalhe
    {
        public Campo UsoExclusivoFebrabanCnab1 { get; set; }
        public Campo ValorIr { get; set; }
        public Campo ValorIss { get; set; }
        public Campo ValorIof { get; set; }
        public Campo ValorOutrasDeducoes { get; set; }
        public Campo ValorOutrosAcrescimos { get; set; }
        public Campo AgenciaFavorecido { get; set; }
        public Campo DigitoVerificadorAgencia { get; set; }
        public Campo NumeroContaCorrente { get; set; }
        public Campo DigitoVerificadorConta { get; set; }
        public Campo DigitoVerificadorAgenciaConta { get; set; }
        public Campo ValorInss { get; set; }
        public Campo NumeroContaPagamentoCreditada { get; set; }
        public Campo UsoExclusivoFebrabanCnab2 { get; set; }

        public RegistroDetalheC()
        {
            UsoExclusivoFebrabanCnab1 = new CampoAlfanumerico(15, 17, "G004");
            ValorIr = new CampoNumerico(18, 32, 2, "G050");
            ValorIss = new CampoNumerico(33, 47, 2, "G051");
            ValorIof = new CampoNumerico(48, 62, 2, "G052");
            ValorOutrasDeducoes = new CampoNumerico(63, 77, 2, "G053");
            ValorOutrosAcrescimos = new CampoNumerico(78, 92, 2, "G054");
            AgenciaFavorecido = new CampoNumerico(93, 97, 0, "*G008");
            DigitoVerificadorAgencia = new CampoAlfanumerico(98, 98, "*G009");
            NumeroContaCorrente = new CampoNumerico(99, 110, 0, "*G010");
            DigitoVerificadorConta = new CampoAlfanumerico(111, 111, "*G011");
            DigitoVerificadorAgenciaConta = new CampoAlfanumerico(112, 112, "*G012");
            ValorInss = new CampoNumerico(113, 127, 2, "G055");
            NumeroContaPagamentoCreditada = new CampoNumerico(128, 147, 0, "P016");
            UsoExclusivoFebrabanCnab2 = new CampoAlfanumerico(148, 240, "G004");

            CodigoSegmentoRegistroDetalhe.Valor = "C";
        }
    }
}
