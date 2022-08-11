using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Investimentos
{
    public interface Investimento
    {
        double CalculaRetorno(ContaBancaria contaBancaria);
    }
}
