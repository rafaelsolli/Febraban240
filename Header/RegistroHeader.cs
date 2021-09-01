namespace Febraban240
{
    abstract class RegistroHeader : Registro
    {
        public Campo TipoInscricaoEmpresa { get; set; }
        public Campo NumeroInscricaoEmpresa { get; set; }
        public Campo CodigoConvenioBanco { get; set; }
        public Campo AgenciaMantenedoraConta { get; set; }
        public Campo DigitoVerificadorAgencia { get; set; }
        public Campo NumeroContaCorrente { get; set; }
        public Campo DigitoVerificadorConta { get; set; }
        public Campo DigitoVerificadorAgenciaConta { get; set; }
        public Campo NomeEmpresa { get; set; }

        protected RegistroHeader()
        {
            TipoInscricaoEmpresa = new CampoNumerico(18, 18, 0, "*G005");
            NumeroInscricaoEmpresa = new CampoNumerico(19, 32, 0, "*G006");
            CodigoConvenioBanco = new CampoAlfanumerico(33, 52, "*G007");
            AgenciaMantenedoraConta = new CampoNumerico(53, 57, 0, "*G008");
            DigitoVerificadorAgencia = new CampoAlfanumerico(58, 58, "*G009");
            NumeroContaCorrente = new CampoNumerico(59, 70, 0, "*G010");
            DigitoVerificadorConta = new CampoAlfanumerico(71, 71, "*G011");
            DigitoVerificadorAgenciaConta = new CampoAlfanumerico(72, 72, "*G012");
            NomeEmpresa = new CampoAlfanumerico(73, 102, "G013");
        }
    }
}
