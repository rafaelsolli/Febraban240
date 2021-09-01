namespace Febraban240
{
    class RegistroTrailerLote046 : RegistroTrailerLote
    {
        public Campo SomatorioQuantidadeMoeda { get; set; }
        public Campo NumeroAvisoDebito { get; set; }
        public Campo UsoExclusivoFebrabanCnab2 { get; set; }

        public RegistroTrailerLote046()
        {
            SomatorioQuantidadeMoeda = new CampoNumerico(42, 59, 5, "G058");
            NumeroAvisoDebito = new CampoNumerico(60, 65, 0, "G066");
            UsoExclusivoFebrabanCnab2 = new CampoAlfanumerico(66, 230, "G004");
        }
    }
}
