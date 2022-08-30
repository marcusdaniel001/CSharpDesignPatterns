using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Descontos
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            
            if (ExisteVendaCasada("Lapis", "Caneta", orcamento))
            {
                return orcamento.Valor * 0.05;
            }

            return Proximo.Desconta(orcamento);
        }

        private static bool ExisteVendaCasada(string objeto, string objeto2, Orcamento orcamento)
        {
            var temObjeto = false;
            var temObjeto2 = false;

            foreach(var item in orcamento.Items)
            {
                if (item.Nome.Equals(objeto)) 
                { 
                    temObjeto = true;
                }

                if (item.Nome.Equals(objeto2)) 
                {
                    temObjeto2 = true;
                }
            }

            return temObjeto && temObjeto2;
        }
    }
}
