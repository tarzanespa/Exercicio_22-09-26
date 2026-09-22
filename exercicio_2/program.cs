int[] notas = new int[5];
int media = 0;

for (int i = 0; i < 5; i++)
{
Console.Write($"\nDigite a {i + 1}ª nota: ");
notas[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
{
media += notas[i];
}

media = media / 5;

Console.WriteLine("\nEstas são as notas do aluno:");

for (int i = 0; i < 5; i++)
{
Console.WriteLine(notas[i]);
}

Console.WriteLine($"\nA média do aluno é: {media}");
