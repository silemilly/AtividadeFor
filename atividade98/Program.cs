Console.WriteLine("Número\tQuadrado\tCubo");

for (int numero = 0; numero <= 10; numero++)
{
    int quadrado = numero * numero;
    int cubo = numero * numero * numero;

    Console.WriteLine(numero + "\t" + quadrado + "\t\t" + cubo);
}
