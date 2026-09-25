using System;
using System.Collections;


int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write("Número: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Número a procurar: ");
int procura = Convert.ToInt32(Console.ReadLine());

bool existe = false;

for (int i = 0; i < 10; i++)
{
    if (numeros[i] == procura)
    {
        existe = true;
        break;
    }
}

if (existe)
{
    Console.WriteLine("O número existe.");
}
else
{
    Console.WriteLine("O número não existe.");
}