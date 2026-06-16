int somaIdadesMenor170 = 0, qtdMenor170 = 0, qtdMaior20 = 0;
double somaAlturasMaior20 = 0;

for (int i = 1; i <= 4; i++)
{
    Console.WriteLine($"Aluno {i}");

    Console.Write("Idade: ");
    int idade = int.Parse(Console.ReadLine());

    Console.Write("Altura (em metros): ");
    double altura = double.Parse(Console.ReadLine());

    // a) Idade média dos alunos com menos de 1,70 m
    if (altura < 1.70)
    {
        somaIdadesMenor170 += idade;
        qtdMenor170++;
    }

    // b) Altura média dos alunos com mais de 20 anos
    if (idade > 20)
    {
        somaAlturasMaior20 += altura;
        qtdMaior20++;
    }

    Console.WriteLine();
}

if (qtdMenor170 > 0)
    Console.WriteLine($"Idade média dos alunos com menos de 1,70m: {(double)somaIdadesMenor170 / qtdMenor170:F2}");
else
    Console.WriteLine("Não há alunos com menos de 1,70m.");

if (qtdMaior20 > 0)
    Console.WriteLine($"Altura média dos alunos com mais de 20 anos: {somaAlturasMaior20 / qtdMaior20:F2} m");
else
    Console.WriteLine("Não há alunos com mais de 20 anos.");