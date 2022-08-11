// See https://aka.ms/new-console-template for more information
using CursoDesignPatterns;
using CursoDesignPatterns.Impostos;
using CursoDesignPatterns.Investimentos;

Imposto iss = new ISS();
Imposto icms = new ICMS();
Imposto iccc = new ICCC();

Orcamento orcamento = new(3001.0);

CalculadorDeImpostos calculador = new();

calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, icms);

calculador.RealizaCalculo(orcamento, iccc);


ContaBancaria contaBancaria = new ContaBancaria(1000);

Investimento conservador = new Conservador();
Investimento moderado = new Moderado();
Investimento arrojado = new Arrojado();

CalculadorDeRendimentos calculadorDeRendimentos = new();

calculadorDeRendimentos.CalculaRendimento(contaBancaria, conservador);
calculadorDeRendimentos.CalculaRendimento(contaBancaria, moderado);
calculadorDeRendimentos.CalculaRendimento(contaBancaria, arrojado);
