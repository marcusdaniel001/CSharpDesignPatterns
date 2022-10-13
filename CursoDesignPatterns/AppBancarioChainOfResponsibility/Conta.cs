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
        public string Agencia { get; private set; }
        public string NumeroConta { get; private set; }

        public Conta(string nomeTitular, double saldo, string agencia, string numeroConta)
        {
            Saldo = saldo;
            NomeTitular = nomeTitular;
            Agencia = agencia;
            NumeroConta = numeroConta;
        }
    }
}
