using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.AppBancarioChainOfResponsibility
{
    public class Requisicao
    {
        public FormatoEnum Formato { get; private set; }

        public Requisicao(FormatoEnum formato)
        {
            Formato = formato;
        }
    }
}
