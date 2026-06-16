int maior = 0, menor = 0, soma = 0;

for (int i = 1; i <= 10; i++)
{
    Console.Write($"Digite o {i}º número inteiro: ");
    int numero = int.Parse(Console.ReadLine());

    if (i == 1)
    {
        maior = numero;
        menor = numero;
    }
    else
    {
        if (numero > maior)
            maior = numero;

        if (numero < menor)
            menor = numero;
    }

    soma += numero;
}

double media = (double)soma / 10;

Console.WriteLine($"\nMédia: {media}");
Console.WriteLine($"Maior número: {maior}");
Console.WriteLine($"Menor número: {menor}");
