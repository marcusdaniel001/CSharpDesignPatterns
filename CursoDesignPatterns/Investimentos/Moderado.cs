namespace CursoDesignPatterns.Investimentos
{
    public class Moderado : Investimento
    {
        public double CalculaRetorno(ContaBancaria contaBancaria)
        {
            var chance = new Random().Next(101);
            var saldo = contaBancaria.Saldo;

            if (chance <= 50)
            {
                var rendimento = (saldo * 0.025) * 0.75;
                return saldo + rendimento;
            }
            else
            {
                var rendimento = (saldo * 0.007) * 0.75;
                return saldo + rendimento;
            }

        }
    }
}
