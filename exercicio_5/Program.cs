using System;
using System.Collections;


ArrayList fila = new ArrayList();

for (int i = 0; i < 3; i++)
{
    Console.Write("Nome do aluno: ");
    fila.Add(Console.ReadLine());
}

Console.WriteLine("\nFila:");
foreach (string nome in fila)
{
    Console.WriteLine(nome);
}


Console.Write("\nAluno que vai entrar na posição 1: ");
string novo = Console.ReadLine() ?? string.Empty;

fila.Insert(1, novo);

Console.WriteLine("\nNova fila:");
foreach (string nome in fila)
{
    Console.WriteLine(nome);
}
