using CursoDesignPatterns.AppBancarioChainOfResponsibility;

namespace CursoDesignPatterns.RelatoriosTemplateMethod
{
    public class MontaEstrutura : RelatorioTemplate
    {
        public override EstruturaRelatorio EstruturaRelatorioComplexo(Banco banco, List<Conta> contas)
        {
            var contasRelatorio = "";
            foreach(var conta in contas)
            {
                contasRelatorio += $"Titular: {conta.NomeTitular}, Agência: {conta.Agencia}, Número da conta: {conta.NumeroConta}, Saldo: {conta.Saldo}; ";
            }

            var estrutura = new EstruturaRelatorio
            (
                cabecalho: $"Nome do banco: {banco.Nome}   Endereço: {banco.Endereco}  Telefone: {banco.Telefone}",
                corpo: contasRelatorio,
                rodape: $"Email: {banco.Email}  Data atual: {banco.DataAtual}"
            );

            return estrutura;
        }

        public override EstruturaRelatorio EstruturaRelatorioSimples(Banco banco, List<Conta> contas)
        {
            var contasRelatorio = "";
            foreach (var conta in contas)
            {
                contasRelatorio += $"Titular: {conta.NomeTitular}, Saldo: {conta.Saldo}; ";
            }

            var estrutura = new EstruturaRelatorio
            (
                cabecalho: $"Nome do banco: {banco.Nome}  Telefone: {banco.Telefone}",
                corpo: contasRelatorio,
                rodape: $"Nome do banco: {banco.Nome}  Telefone: {banco.Telefone}"
            );

            return estrutura;
        }
    }
}
