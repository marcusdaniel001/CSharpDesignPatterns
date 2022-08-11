namespace CursoDesignPatterns.Impostos
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            var valor = orcamento.Valor;

            if(valor < 1000)
            {
                return valor * 0.05;
            }
            else if(valor >= 1000 && valor <= 3000)
            {
                return valor * 0.07;
            }
            else
            {
                return (valor * 0.08)+30;
            }
        }
    }
}
