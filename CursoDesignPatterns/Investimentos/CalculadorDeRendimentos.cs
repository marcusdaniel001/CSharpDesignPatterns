using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Investimentos
{
    public class CalculadorDeRendimentos
    {
        public void CalculaRendimento(ContaBancaria contaBancaria, Investimento tipoInvestimento)
        {
            var retorno =  tipoInvestimento.CalculaRetorno(contaBancaria);
            Console.WriteLine(retorno);
        }
    }
}
