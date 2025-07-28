int num = 0;
int[] arr = new int[5];

for (int i = 0; i < 5; i++)
{
    int a = int.Parse(Console.ReadLine());
    num += a;
    arr[i] = a;

}
Array.Sort(arr);
Console.WriteLine(num/5);
Console.WriteLine(arr[2]);