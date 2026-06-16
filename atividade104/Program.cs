Console.Write("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

int resultado = 0;
bool negativo = false;

if (num2 < 0)
{
    negativo = true;
    num2 = -num2;
}

for (int i = 0; i < num2; i++)
{
    resultado += num1;
}

if (negativo)
{
    resultado = -resultado;
}

Console.WriteLine($"Resultado: {resultado}");
