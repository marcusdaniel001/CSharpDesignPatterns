using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.ImpostosTemplateMethod
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return Tem2ItemsMesmoNome(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Items.Count());
        }

        private bool Tem2ItemsMesmoNome(Orcamento orcamento)
        {
            var nomesAgrupados = orcamento.Items.GroupBy(item => item.Nome).Select(group => new {
                Item = group.Key,
                Quantidade = group.Count()
            });

            foreach (var listNome in nomesAgrupados) {
                if (listNome.Quantidade < 2) continue;
                
                return listNome.Quantidade >= 2;
            }

            return false;
        }
    }
}
