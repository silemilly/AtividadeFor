int A, B;

Console.WriteLine("Executar 10 vezes!!");
for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Digite o valor de A: ");
    A = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor de B: ");
    B = int.Parse(Console.ReadLine());
    Console.WriteLine($"O resto da divisão de {A} por {B} é {A % B}");
}

Console.WriteLine(" Não executar nenhuma vez!!");
for (int i = 0; i < 0; i++)
{
    Console.WriteLine("Digite o valor de A: ");
    A = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor de B: ");
    B = int.Parse(Console.ReadLine());
    Console.WriteLine($"O resto da divisão de {A} por {B} é {A % B}");
}

Console.WriteLine("Executar 100 vez!!");
for (int i = 0; i < 2; i++)
{
    for (int x = 0; x < 50; x++ )
    Console.WriteLine("Digite o valor de A: ");
    A = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor de B: ");
    B = int.Parse(Console.ReadLine());
    Console.WriteLine($"O resto da divisão de {A} por {B} é {A % B}");
}

Console.WriteLine("Digite o numero a ser executado:");
int numero = int.Parse(Console.ReadLine());

for (int i = 0; i < numero; i++)
{
    Console.WriteLine("Digite o valor de A: ");
    A = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor de B: ");
    B = int.Parse(Console.ReadLine());
    Console.WriteLine($"O resto da divisão de {A} por {B} é {A % B}");
}
