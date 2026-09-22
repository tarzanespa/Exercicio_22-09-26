int[] numeros = new int[6];

for (int i = 0; i < numeros.Length; i++)
{
Console.Write($"Digite o {i + 1}º número: ");
numeros[i] = Convert.ToInt32(Console.ReadLine());
}

int maior = numeros[0];

for (int i = 1; i < 6; i++)
{
if (numeros[i] > maior)
{
maior = numeros[i];
}
}

Console.WriteLine($"\nO maior número é: {maior}");
