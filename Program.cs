Console.WriteLine("Digite uma opção de 1 a 3");
var opcao = Console.ReadLine();

if (opcao == "1") {
    Console.WriteLine("Você entrou no menu de Cadastro");
} else if (opcao == "2") {
    Console.WriteLine("Você entrou no menu de Reclamação");
} else if (opcao == "3") {
    Console.WriteLine("Você entrou no menu de Atendimento de Suporte");
} else {
    Console.WriteLine("Opção inválida");
}

switch (opcao){
    case "1":
        Console.WriteLine("Você entrou no menu de Cadastro");
        break;
    case "2":
        Console.WriteLine("Você entrou no menu de Reclamação");
        break;
    case "3": 
        Console.WriteLine("Você entrou no menu de Atendimento de Suporte");
        break;    
    default:
        Console.WriteLine("Opção inválida");
        break;
}