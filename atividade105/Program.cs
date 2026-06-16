int a = 0;
int b = 1;
int proximo;

Console.WriteLine("Série de Fibonacci (20 termos):");

for (int i = 1; i <= 20; i++)
{
    Console.Write(a + " ");

    proximo = a + b;
    a = b;
    b = proximo;
}
