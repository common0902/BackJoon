int[] arr = new int[28];
bool isNumber = false;

for (int i = 0; i < 28; i++)
{
    int a = int.Parse(Console.ReadLine());
    arr[i] = a;
}

for (int i = 0; i < 30; i++)
{
    for (int j = 0; j < 28; j++)
    {
        if (arr[j] == i+1)
        {
            isNumber = true;
            break;
        }
    }
    if (!isNumber)
    {
        Console.WriteLine(i+1);
    }
    isNumber = false;

}