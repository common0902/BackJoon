int[] arr = new int[4];

for (int i = 0; i < 4; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int count = 0;
int cont1 = arr[0];

for (int i = 0; i < 4; i++)
{
    count += arr[i];

    if (arr[i] < cont1)
    {
        cont1 = arr[i];
    }
}

int count2;
if (a > b)
{
    count2 = a;
}
else
{
    count2 = b;
}

int count3 = count - cont1 + count2;
Console.WriteLine(count3);