// See https://aka.ms/new-console-template for more information
Random random = new Random();
int numeroSorteado = random.Next(1, 7);
Console.WriteLine("Insira um numero de 1 a 6: ");
if (int.TryParse(Console.ReadLine(), out int numeroEscolhido))
{
    Console.WriteLine($"O revólver caiu em: {numeroSorteado}");
 if (numeroEscolhido == numeroSorteado)
 {
    Console.WriteLine("Você morreu!");
 }

 else 
 {
    Console.WriteLine("Você sobreviveu ");
 }
}

