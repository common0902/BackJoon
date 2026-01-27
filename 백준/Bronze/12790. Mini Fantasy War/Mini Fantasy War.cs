int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int b = Math.Max(1, arr[0] + arr[4]);
    int c = Math.Max(1, arr[1] + arr[5]);
    int d = Math.Max(0, arr[2] + arr[6]);
    int e = arr[3] + arr[7];

    int num = b + 5 * c + 2 * d + 2 * e;
    Console.WriteLine(num);
}