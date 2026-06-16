Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"Tabuada do {numero}:");

for (int i = 1; i <= 13; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}
