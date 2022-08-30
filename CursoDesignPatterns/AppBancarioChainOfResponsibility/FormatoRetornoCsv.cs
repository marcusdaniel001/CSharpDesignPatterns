using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.AppBancarioChainOfResponsibility
{
    public class FormatoRetornoCsv : Formato
    {
        public Formato ProximoFormato { get; set; }
        public string FormatoRetorno(Conta conta, FormatoEnum formato)
        {
            if (formato == FormatoEnum.CSV)
                return "CSV";

            return ProximoFormato.FormatoRetorno(conta, formato);
        }
    }
}
