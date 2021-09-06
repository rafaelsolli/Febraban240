namespace Febraban240
{
    public class SegmentoC
    {
        public GrupoControle Controle = new GrupoControle();
        public class GrupoControle
        {
            public Campo Banco = new CampoNumerico(1, 3, 0, "G001");
            public Campo Lote = new CampoNumerico(4, 7, 0, "G002");
            public Campo Registro = new CampoNumerico(8, 8, 0, "G003", "3");
        }
        public GrupoServico Servico = new GrupoServico();
        public class GrupoServico
        {
            public Campo NumeroRegistro = new CampoNumerico(9, 13, 0, "G038");
            public Campo Segmento = new CampoAlfanumerico(14, 14, "G039", "C");
        }
        public Campo Cnab1 = new CampoAlfanumerico(15, 17, "G004");
        public GrupoDadosComplementares DadosComplementares = new GrupoDadosComplementares();
        public class GrupoDadosComplementares
        {
            public Campo ValorIr = new CampoNumerico(18, 32, 2, "G050");
            public Campo ValorIss = new CampoNumerico(33, 47, 2, "G051");
            public Campo ValorIof = new CampoNumerico(48, 62, 2, "G052");
            public Campo ValorOutrasDeducoes = new CampoNumerico(63, 77, 2, "G053");
            public Campo ValorOutrosAcrescimos = new CampoNumerico(78, 92, 2, "G054");
        }
        public GrupoSubstituta Substituta = new GrupoSubstituta();
        public class GrupoSubstituta
        {
            public GrupoAgencia Agencia = new GrupoAgencia();
            public class GrupoAgencia
            {
                public Campo Codigo = new CampoNumerico(93, 97, 0, "G008");
                public Campo DV = new CampoAlfanumerico(98, 98, "G009");
            }
            public GrupoConta Conta = new GrupoConta();
            public class GrupoConta
            {
                public Campo Numero = new CampoNumerico(99, 110, 0, "G010");
                public Campo DV = new CampoAlfanumerico(111, 111, "G011");
            }
            public Campo DV = new CampoAlfanumerico(112, 112, "G012");
        }
        public Campo ValorInss = new CampoNumerico(113, 127, 2, "G055");
        public Campo NumeroContaPagamentoCreditada = new CampoNumerico(128, 147, 0, "P016");
        public Campo Cnab2 = new CampoAlfanumerico(148, 240, "G004");
    }
}
