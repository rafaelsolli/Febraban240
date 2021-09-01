namespace Febraban240
{
    class RegistroTrailerLote012 : RegistroTrailerLote
    {

        public Campo ComplementoRegistro { get; set; }

        public RegistroTrailerLote012()
        {
            ComplementoRegistro = new CampoAlfanumerico(42, 230, "B003");
        }
    }
}
