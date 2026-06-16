int produto = 1;

Console.WriteLine("Números ímpares de 1 a 15:");

for (int i = 1; i <= 15; i += 2)
{
    Console.Write(i + " ");
    produto *= i;
}

Console.WriteLine("Produto = " + produto);