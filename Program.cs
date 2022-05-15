var valores = Console.ReadLine();
var valoresArray = valores.Split(" ");

for (var i = 0; i < valoresArray.Length; i++) {
    Console.Write(valoresArray[i] + " ");
}

var contador = 0;
while(contador < valoresArray.Length) {
    Console.Write(valoresArray[contador] + " ");
    contador++;
}

foreach (var item in valoresArray){
    Console.Write(item + " ");
}