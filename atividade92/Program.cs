Console.WriteLine("Digite N: ");
int N = int.Parse(Console.ReadLine());

double A = 0;

for (int i = 1; i <= N; i++)
{
    A += (double)(N - i + 1) / i;
}
Console.WriteLine("Valor de A: " + A);
