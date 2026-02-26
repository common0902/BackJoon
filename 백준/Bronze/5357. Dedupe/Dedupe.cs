int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    string b = Console.ReadLine();
    string c = "";

    for (int j = 0; j < b.Length; j++)
    {
        if (c != b[j].ToString())
        {
            Console.Write(b[j].ToString());
            c = b[j].ToString();
        }

    }
    Console.WriteLine();
}