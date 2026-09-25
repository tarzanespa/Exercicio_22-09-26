string[] fila = new string[4];



for (int i = 0; i < 3; i++)
{
    Console.Write("Nome do aluno: ");

    fila[i] = Console.ReadLine() ?? string.Empty;
    
}

Console.WriteLine("\nFila:");
for (int i = 0; i < 3; i++)
    Console.WriteLine(fila[i]);

Console.Write("\nAluno que vai entrar na posição 1: ");


string novo = Console.ReadLine() ?? string.Empty;

// Deslocar os alunos
fila[3] = fila[2];
fila[2] = fila[1];
fila[1] = novo;

Console.WriteLine("\nNova fila:");
for (int i = 0; i < 4; i++)
    Console.WriteLine(fila[i]);