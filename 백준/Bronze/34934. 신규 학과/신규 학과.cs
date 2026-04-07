int a = int.Parse(Console.ReadLine());

string b = "";
int c = 0;

for (int i = 0; i < a; i++)
{
    string[] arr = Console.ReadLine().Split(" ");
    if (c < int.Parse(arr[1]))
    {
        b = arr[0];
        c = int.Parse(arr[1]);
    }
}
Console.WriteLine(b);