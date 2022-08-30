using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.AppBancarioChainOfResponsibility
{
    public class FormatoRetornoPorcento : Formato
    {
        public Formato ProximoFormato { get; set; }
        public string FormatoRetorno(Conta conta, FormatoEnum formato)
        {
            if (formato == FormatoEnum.PORCENTO)
                return "PORCENTO";

            if (ProximoFormato == null) return "Fim da Execucao";

            return ProximoFormato.FormatoRetorno(conta, formato);
        }
    }
}
