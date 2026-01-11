int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    string c = Console.ReadLine();
    Console.WriteLine(char.ToUpper(c[0]) + c.Substring(1));
}