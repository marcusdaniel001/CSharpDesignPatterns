using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.RelatoriosTemplateMethod
{
    public class Banco
    {
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public DateTime DataAtual { get; set; } = DateTime.Now;

        public Banco(string nome, string endereco, string telefone, string email)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }
    }
}
