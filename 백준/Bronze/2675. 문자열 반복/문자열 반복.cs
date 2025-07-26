int a = int.Parse(Console.ReadLine());

string result = "";

for (int i = 0; i < a; i++)
{
    string[] bc = Console.ReadLine().Split(' ');
    int b = int.Parse(bc[0]);
    string c = bc[1];
    
    for (int j = 0; j < c.Length; j++)
    {
        for (int k = 0; k < b; k++)
        {
            result += c[j];
        }
    }
    Console.WriteLine(result);
    result = string.Empty;
}