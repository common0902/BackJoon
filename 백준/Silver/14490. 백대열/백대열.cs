int[] arr = Array.ConvertAll(Console.ReadLine().Split(":"), int.Parse);
int a = arr[0];
int b = arr[1];

for (int i = a < b ? a : b; 0 < i; --i)
{
    if (a % i == 0 && b % i == 0)
    {
        a /= i;
        b /= i;
        break;
    }
}
Console.WriteLine($"{a}:{b}");