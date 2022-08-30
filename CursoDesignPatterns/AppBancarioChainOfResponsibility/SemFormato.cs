using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.AppBancarioChainOfResponsibility
{
    public class SemFormato : Formato
    {
        public Formato ProximoFormato { get; set; }

        public string FormatoRetorno(Conta conta, FormatoEnum formato)
        {
            return "FormatoIncorreto";
        }
    }
}
