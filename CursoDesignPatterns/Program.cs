// See https://aka.ms/new-console-template for more information
using CursoDesignPatterns;
using CursoDesignPatterns.AppBancarioChainOfResponsibility;
using CursoDesignPatterns.Descontos;
using CursoDesignPatterns.Impostos;
using CursoDesignPatterns.ImpostosTemplateMethod;
using CursoDesignPatterns.Investimentos;
using CursoDesignPatterns.RelatoriosTemplateMethod;
using System.Text.Json;

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
orcamento.AdicionaItem(new Item("Lapis", 500));
orcamento.AdicionaItem(new Item("Lapis", 500));

double desconto = calculaDesconto.Calcula(orcamento);
Console.WriteLine($"Desconto - {desconto}");


var conta = new Conta("ze",800, "001", "12313");
var requisicao = new Requisicao(FormatoEnum.XML);

MontaCadeiaRequisicao MontaCadeiaRequisicao = new();
var formato = MontaCadeiaRequisicao.RetornaFormato(requisicao, conta);
Console.WriteLine($"Formato - {formato}");

var icpp = new ICPP();
var ikcv = new IKCV();
var ihit = new IHIT();

Console.WriteLine($"Imposto ICPP - {icpp.Calcula(orcamento)}");
Console.WriteLine($"Imposto IKCV - {ikcv.Calcula(orcamento)}");
Console.WriteLine($"Imposto IHIT - {ihit.Calcula(orcamento)}");

var relatorio = new MontaEstrutura();
var banco = new Banco("btgp", "Faria lima", "011 93939393", "btg@btg");
var contas = new List<Conta> { conta, conta };
Console.WriteLine($"Relatorio complexo - {JsonSerializer.Serialize(relatorio.RetornaRelatorio(true, banco, contas))}");
Console.WriteLine($"Relatorio simples - {JsonSerializer.Serialize(relatorio.RetornaRelatorio(false, banco, contas))}");
