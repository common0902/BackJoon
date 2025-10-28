int a = int.Parse(Console.ReadLine());

List<int> list = new List<int>();

long num = 0;

for (int i = 0; i < a; i++)
{
    int b = int.Parse(Console.ReadLine());
    list.Add(b);    
    
    num += b;
}

int c = (int)Math.Round((double)num / a, MidpointRounding.AwayFromZero);
list.Sort();

int[] arr = new int[8001];

foreach (int i in list)
{
    arr[i + 4000]++;
}

int d = arr.Max();
int e = 0;

int num2 = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] != 0)
    {
        if (arr[i] == d)
        {
            num2++;
            e = i - 4000;
        }
    }
    if (num2 >= 2)
    {
        break;
    }
}

Console.WriteLine(c); 
Console.WriteLine(list[list.Count / 2]);
Console.WriteLine(e);
Console.WriteLine(list.Max() - list.Min());