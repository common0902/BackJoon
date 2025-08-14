int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    string b = Console.ReadLine();

    int num = 0;
    int sum = 0;

    for (int j = 0; j < b.Length; j++)
    {
        if (b[j] == 'O')
        {
            num++;
        }
        else if (b[j] == 'X')
        {
            num = 0;
        }
        sum += num;
    }
    Console.WriteLine(sum);

}