
double totalHotel = 0;

for (int i = 1; i <= 30; i++)
{
    Console.WriteLine($"\nCliente {i}");

    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Número de diárias: ");
    int diarias = int.Parse(Console.ReadLine());

    double taxaServico;

    if (diarias < 15)
    {
        taxaServico = 4.00;
    }
    else if (diarias == 15)
    {
        taxaServico = 3.60;
    }
    else
    {
        taxaServico = 3.00;
    }

    double totalConta = diarias * (50.00 + taxaServico);

    Console.WriteLine($"Cliente: {nome}");
    Console.WriteLine($"Total da conta: R$ {totalConta:F2}");

    totalHotel += totalConta;
}

Console.WriteLine($"\nTotal ganho pelo hotel: R$ {totalHotel:F2}");
