// See https://aka.ms/new-console-template for more information
using CursoDesignPatterns;
using CursoDesignPatterns.Descontos;
using CursoDesignPatterns.Impostos;
using CursoDesignPatterns.Investimentos;

Imposto iss = new ISS();
Imposto icms = new ICMS();
Imposto iccc = new ICCC();

Orcamento orcamento = new(500);

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


CalculadorDeDescontos calculaDesconto = new CalculadorDeDescontos();

orcamento.AdicionaItem(new Item("Caneta", 500));
orcamento.AdicionaItem(new Item("Lapis", 500));

double desconto = calculaDesconto.Calcula(orcamento);
Console.WriteLine($"Desconto - {desconto}");