int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write("Número: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nNúmeros sem duplicados:");

for (int i = 0; i < 10; i++)
{
    bool repetido = false;

    for (int j = 0; j < i; j++)
    {
        if (numeros[i] == numeros[j])
        {
            repetido = true;
            break;
        }
    }

    if (!repetido)
        Console.WriteLine(numeros[i]);
}