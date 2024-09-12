int n, escolha = 0, cont = 0;

Random segredo = new Random();

n = Convert.ToInt32(segredo.Next(1, 10));

Console.WriteLine("*** JOGO DA ADIVINHAÇÃO");
Console.WriteLine("Advinhe o número que pensei");
Console.WriteLine("(Dica: O número está entre 1 e 10): ");

try
{
    while (escolha != n)
    {
        escolha = Convert.ToInt32(Console.ReadLine());

        if (escolha > n)
        {
            Console.WriteLine("Errado o número é menor");
        }
        else if (escolha < n)
        {
            Console.WriteLine("Errado o número é maior");
        }
        else if (escolha == n && cont == 0)
        {
            Console.WriteLine("Incrível! Você acertou na primeira");
        }
        else
        {
            Console.WriteLine("Acertou!" + n + " é o número!");
        }
        cont++;
    }
    Console.WriteLine("Número de tentativas: " + cont);
    Console.ReadKey();
}
catch
{
    Console.WriteLine("Sinto muito você perdeu!");
}