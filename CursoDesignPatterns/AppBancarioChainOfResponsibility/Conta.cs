using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.AppBancarioChainOfResponsibility
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string NomeTitular { get; private set; }

        public Conta(string nomeTitular, double saldo)
        {
            Saldo = saldo;
            NomeTitular = nomeTitular;
        }
    }
}
