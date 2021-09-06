namespace Febraban240
{
    public class HeaderArquivo
    {
        public GrupoControle Controle = new GrupoControle();
        public class GrupoControle
        {
            public Campo Banco = new CampoNumerico(1, 3, 0, "G001");
            public Campo Lote = new CampoNumerico(4, 7, 0, "G002", "0000");
            public Campo Registro = new CampoNumerico(8, 8, 0, "G003", "0");
        }
        public Campo Cnab1 = new CampoAlfanumerico(9, 17, "G004");
        public GrupoEmpresa Empresa = new GrupoEmpresa();
        public class GrupoEmpresa
        {
            public GrupoInscricao Inscricao = new GrupoInscricao();
            public class GrupoInscricao
            {
                public Campo Tipo = new CampoNumerico(18, 18, 0, "G005");
                public Campo Numero = new CampoNumerico(19, 32, 0, "G006");
            }
            public Campo Convenio = new CampoAlfanumerico(33, 52, "G007");
            public GrupoContaCorrente ContaCorrente = new GrupoContaCorrente();
            public class GrupoContaCorrente
            {
                public GrupoAgencia Agencia = new GrupoAgencia();
                public class GrupoAgencia
                {
                    public Campo Codigo = new CampoNumerico(53, 57, 0, "G008");
                    public Campo DV = new CampoAlfanumerico(58, 58, "G009");
                }
                public GrupoConta Conta = new GrupoConta();
                public class GrupoConta
                {
                    public Campo Numero = new CampoNumerico(59, 70, 0, "G010");
                    public Campo DV = new CampoAlfanumerico(71, 71, "G011");
                }
                public Campo DV = new CampoAlfanumerico(72, 72, "G012");
            }
            public Campo Nome = new CampoAlfanumerico(73, 102, "G013");
        }
        public Campo NomeBanco = new CampoAlfanumerico(103, 132, "G014");
        public Campo Cnab2 = new CampoAlfanumerico(133, 142, "G004");
        public GrupoArquivo Arquivo = new GrupoArquivo();
        public class GrupoArquivo
        {
            public Campo Codigo = new CampoNumerico(143, 143, 0, "G015");
            public Campo DataGeracao = new CampoNumerico(144, 151, 0, "G016");
            public Campo HoraGeracao = new CampoNumerico(152, 157, 0, "G017");
            public Campo NSA = new CampoNumerico(158, 163, 0, "G018");
            public Campo LayoutArquivo = new CampoNumerico(164, 166, 0, "G019", "103");
            public Campo Densidade = new CampoNumerico(167, 171, 0, "G020");
        }
        public Campo ReservadoBanco = new CampoAlfanumerico(172, 191, "G021");
        public Campo ReservadoEmpresa = new CampoAlfanumerico(192, 211, "G022");
        public Campo Cnab3 = new CampoAlfanumerico(212, 240, "G004");
    }
}
