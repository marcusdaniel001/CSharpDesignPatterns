using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.AppBancarioChainOfResponsibility
{
    public interface Formato
    {
        string FormatoRetorno(Conta conta, FormatoEnum formato);
        public Formato ProximoFormato { get; set; }
    }
}
