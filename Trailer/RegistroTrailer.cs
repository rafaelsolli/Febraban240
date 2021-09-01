namespace Febraban240
{
    abstract class RegistroTrailer : Registro
    {
        public Campo UsoExclusivoFebrabanCnab1 { get; set; }

        protected RegistroTrailer()
        {
            UsoExclusivoFebrabanCnab1 = new CampoAlfanumerico(9, 17, "G004");
        }
    }
}
