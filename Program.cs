var notas = new List<int> { 10, 5, 3, 2, 10, 4, 5, 6, 8, 2};

var anyNota1 = notas.Any(n => n == 1);
var FirstNota10 = notas.First(n => n == 10);
var singleNota8 = notas.Single(n => n == 8);
var orderedNotas = notas.OrderBy(n => n);
var max = notas.Max();
var min = notas.Min();
var sum = notas.Sum();
var average = notas.Average();

Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average}");

foreach (var nota in orderedNotas){
    Console.Write(nota + " ");    
}