List<string> names = new List<string>();

Console.Write("Enter player name (-1 to exit): ");
string playerName = Console.ReadLine();

while (playerName != "-1")
{
    names.Add(playerName);

    Console.Write("Enter player name (-1 to exit): ");
    playerName = Console.ReadLine();
}

names.Sort();

foreach(string name in names)
{
    Console.WriteLine(name);
}
