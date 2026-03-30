class Program
{
    static void Main()
    {
        Console.WriteLine("=== Estrenvista divertida ===");

        // pergunta o nome
        Console.Write("Qual é o seu nome? ");
        string nome = Console.ReadLine();

        // pergunta a idade 
        Console.Write("quantos anos você tem? ");
        int idade = int.Parse(Console.ReadLine());

        // pergunta a comida favorita
        Console.Write("qual é a sua comida favorita? ");
        string comida = Console.ReadLine();

        // pergunta um número
        Console.Write("digite um número da sorte: ");
        int numero = int.Parse(Console.ReadLine());

        // faz uma conta com número da sorte
        int resultado = numero * 3 - idade;

        // resposta divertida
        Console.WriteLine($"prazer em te conhecer, {nome}!");
        Console.WriteLine($"você tem {idade} anos e adora {comida}.");
        Console.WriteLine($"seu número da sorte ({numero}) foi processado pelos meus super algoritmos...");
        Console.WriteLine($" e eu descobri que o resultado misterioso é: {resultado}!");


    }

}
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
   