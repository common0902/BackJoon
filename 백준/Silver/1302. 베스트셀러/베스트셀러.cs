int a = int.Parse(Console.ReadLine());
int count = 1;
int max = 1;
string b = "";

string[] arr = new string[a];

for(int i = 0; i < a; i++)
{
    arr[i] = Console.ReadLine();
}
Array.Sort(arr);
b = arr[0];

for (int i = 1; i < arr.Length; ++i)
{
    if (arr[i] == arr[i - 1])
        count++;
    else
        count = 1;

    if (count > max)
    {
        max = count;
        b = arr[i];
    }
}

Console.WriteLine(b);