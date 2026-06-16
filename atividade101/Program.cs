Console.Write("Digite um número: ");
int n = int.Parse(Console.ReadLine());

long fatorial = 1;

if (n == 0)
{
    fatorial = 1;
}
else
{
    for (int i = 1; i <= n; i++)
    {
        fatorial *= i;
    }
}

Console.WriteLine($"O fatorial de {n} é {fatorial}");
