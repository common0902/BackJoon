while (true)
{
    string a = Console.ReadLine();

    if (a == "end") break;

    switch (a)
    {
        case "animal":
            Console.WriteLine("Panthera tigris");
            break;
        case "tree":
            Console.WriteLine("Pinus densiflora");
            break;
        case "flower":
            Console.WriteLine("Forsythia koreana");
            break;
    }
}