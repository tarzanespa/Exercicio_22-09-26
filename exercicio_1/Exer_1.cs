string[] produtos = new string[5];

for (int i = 0; i < 5; i++)
{
Console.Write($"Digite o {i + 1}º produto: ");
produtos[i] = Console.ReadLine() ?? "";
}

Console.WriteLine("\nEstes são os produtos:");

for (int i = 0; i < 5; i++)
{
Console.WriteLine(produtos[i]);
}
