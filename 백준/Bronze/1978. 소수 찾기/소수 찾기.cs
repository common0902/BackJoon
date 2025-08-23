int a = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int count = 0;
int count1 = 0;

for (int i = 0; i < a; i++)
{
   for (int j = 1; j <= arr[i]; j++)
    {
        if (arr[i] % j == 0)
        {
            count++;
        }
    }
   if (count == 2)
    {
        count1++;
    }
    count = 0;
}
Console.WriteLine(count1);