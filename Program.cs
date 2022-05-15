// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite o seu nome: ");

var nome = Console.ReadLine();
//tipo explicito
//string nome1 = Console.ReadLine();

//Console.WriteLine(nome);
//Console.WriteLine("Olá, " + nome);
//interpolação
Console.WriteLine($"Olá, {nome}");

var umaString = "Essa é uma string";
var numeroInt = 5;
var numeroFloat = 5.4f;
var numeroDouble = 5.4;
var numeroDecimal = 5.3m;
var array = new int[3] { 1, 2, 3};
var caractere = 'a';
var date = new DateTime(1990, 1, 1);