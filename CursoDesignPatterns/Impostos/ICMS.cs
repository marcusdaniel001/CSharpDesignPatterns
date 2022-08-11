﻿namespace CursoDesignPatterns.Impostos
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
