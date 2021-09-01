using System.Collections.Generic;

namespace Febraban240
{
    class Arquivo
    {
        public RegistroHeaderArquivo HeaderArquivo { get; set; }
        public List<Lote> Lotes { get; set; }
        public RegistroTrailerArquivo TrailerArquivo { get; set; }
    }
}
