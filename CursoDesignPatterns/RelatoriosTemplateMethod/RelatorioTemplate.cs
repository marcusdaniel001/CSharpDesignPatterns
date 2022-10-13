using CursoDesignPatterns.AppBancarioChainOfResponsibility;

namespace CursoDesignPatterns.RelatoriosTemplateMethod
{
    public abstract class RelatorioTemplate
    {
        public EstruturaRelatorio RetornaRelatorio(bool complexo, Banco banco, List<Conta> contas)
        {
            if (complexo)
            {
                return EstruturaRelatorioComplexo(banco, contas);
            }

            return EstruturaRelatorioSimples(banco, contas);
        }

        public abstract EstruturaRelatorio EstruturaRelatorioComplexo(Banco banco, List<Conta> contas);
        public abstract EstruturaRelatorio EstruturaRelatorioSimples(Banco banco, List<Conta> contas);
    }
}
