Console.Write("Digite a quantidade de funcionários: ");
int quantidade = int.Parse(Console.ReadLine());

double somaSalarios = 0;
double maiorSalario = 0;
double menorSalario = 0;

for (int i = 0; i < quantidade; i++)
{
    Console.Write($"\nDigite o nome do funcionário {i + 1}: ");
    string nome = Console.ReadLine();

    Console.Write($"Digite o salário de {nome}: ");
    double salario = double.Parse(Console.ReadLine());

    somaSalarios += salario;

    if (i == 0)
    {
        maiorSalario = salario;
        menorSalario = salario;
    }
    else
    {
        if (salario > maiorSalario)
            maiorSalario = salario;

        if (salario < menorSalario)
            menorSalario = salario;
    }
}

double media = somaSalarios / quantidade;

Console.WriteLine("\n--- Resultados ---");
Console.WriteLine($"Média dos salários: R$ {media:F2}");
Console.WriteLine($"Maior salário: R$ {maiorSalario:F2}");
Console.WriteLine($"Menor salário: R$ {menorSalario:F2}");