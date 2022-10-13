using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.RelatoriosTemplateMethod
{
    public class EstruturaRelatorio
    {
        public string Cabecalho { get; private set; }
        public string Corpo { get; private set; }
        public string Rodape { get; private set; }

        public EstruturaRelatorio(string cabecalho, string corpo, string rodape)
        {
            Cabecalho = cabecalho;
            Corpo = corpo;
            Rodape = rodape;
        }
    }
}
