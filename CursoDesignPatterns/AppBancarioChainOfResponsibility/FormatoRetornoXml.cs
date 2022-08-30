using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.AppBancarioChainOfResponsibility
{
    public class FormatoRetornoXml : Formato
    {
        public Formato ProximoFormato { get; set; }

        public string FormatoRetorno(Conta conta, FormatoEnum formato)
        {
            if (formato == FormatoEnum.XML)
                return "XML";

            return ProximoFormato.FormatoRetorno(conta, formato);
        }
    }
}
