namespace Febraban240
{
    public class TrailerLote046
    {
        public GrupoControle Controle = new GrupoControle();
        public class GrupoControle
        {
            public Campo Banco = new CampoNumerico(1, 3, 0, "G001");
            public Campo Lote = new CampoNumerico(4, 7, 0, "G002");
            public Campo Registro = new CampoNumerico(8, 8, 0, "G003", "5");
        }
        public Campo Cnab1 = new CampoAlfanumerico(9, 17, "G004");
        public GrupoTotais Totais = new GrupoTotais();
        public class GrupoTotais
        {
            public Campo QuantidadeRegistros = new CampoNumerico(18, 23, 0, "G057");
            public Campo Valor = new CampoNumerico(24, 41, 2, "P007");
            public Campo QuantidadeMoeda = new CampoNumerico(42, 59, 5, "G058");
        }
        public Campo NumeroAvisoDebito = new CampoNumerico(60, 65, 0, "G066");
        public Campo Cnab2 = new CampoAlfanumerico(66, 230, "G004");
        public Campo Ocorrencias = new CampoAlfanumerico(231, 240, "G059");
    }
}
