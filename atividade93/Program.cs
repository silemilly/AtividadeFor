int casas, graos = 1, total = 0;

Console.WriteLine("Digite a quantidade de casa do tatuleito: ");
casas = int.Parse(Console.ReadLine());

for (int i = 1;  i <= casas; i++)
{
    total = total + graos;
    graos = graos * 2;
}
Console.WriteLine("Total de grãos: " + total);