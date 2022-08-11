namespace CursoDesignPatterns.Investimentos
{
    public class Conservador : Investimento
    {
        public double CalculaRetorno(ContaBancaria contaBancaria)
        {
            var saldo = contaBancaria.Saldo;
            var rendimento = (saldo * 0.008) * 0.75;
            return saldo + rendimento;
        }
    }
}
