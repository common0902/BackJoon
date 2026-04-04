string a = Console.ReadLine();

int[] arr = new int[100];
int index = 0;
int num = 0;
bool um = true;
a = a.ToUpper();
for (int i = 0; i < a.Length; ++i)
{
    arr[a[i]]++;
}

for (int i = 0; i < arr.Length; ++i)
{
    if (num < arr[i])
    {
        um = true;
        num = arr[i];
        index = i;
    }
    else if (num == arr[i])
    {
        um = false;
    }
}
Console.WriteLine(um ? (char)index : '?');