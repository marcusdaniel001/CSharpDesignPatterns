namespace CursoDesignPatterns.Investimentos
{
    public class Arrojado : Investimento
    {
        public double CalculaRetorno(ContaBancaria contaBancaria)
        {
            var chance = new Random().Next(101);
            var saldo = contaBancaria.Saldo;

            if (chance <= 20)
            {
                var rendimento = (saldo * 0.05) * 0.75;
                return saldo + rendimento;
            }
            else if (chance <= 30)
            {
                var rendimento = (saldo * 0.03) * 0.75;
                return saldo + rendimento;
            }
            else
            {
                var rendimento = (saldo * 0.006) * 0.75;
                return saldo + rendimento;
            }
        }
    }
}
