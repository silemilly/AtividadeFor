int numero, somaPositivo = 0, quantNegativo = 0;
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("Digite um número Positivo: ");
    numero = int.Parse(Console.ReadLine());
    if (numero > 0)
    {
        somaPositivo = somaPositivo + numero;
    }
    else
    {
        quantNegativo++;
    }
}
Console.WriteLine("Soma dos números positivos: " + somaPositivo);
Console.WriteLine("Quantidade de números negativos: " + quantNegativo);