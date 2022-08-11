// See https://aka.ms/new-console-template for more information
using CursoDesignPatterns;

Imposto iss = new ISS();
Imposto icms = new ICMS();

Orcamento orcamento = new(500.0);

CalculadorDeImpostos calculador = new();

calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, icms);
