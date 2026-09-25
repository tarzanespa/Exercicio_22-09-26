
using System;
using System.Collections;



ArrayList numeros = new ArrayList();

for (int i = 0; i < 10; i++)
{
    Console.Write("Número: ");
    numeros.Add(Convert.ToInt32(Console.ReadLine()));
}

Console.Write("Número a procurar: ");
int procura = Convert.ToInt32(Console.ReadLine());

if (numeros.Contains(procura))
{
    Console.WriteLine("O número existe.");
}

else
{
    Console.WriteLine("O número não existe.");
}
Console.ReadLine();




