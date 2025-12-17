int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int b = arr[0];
    int c = arr[1];

    Console.WriteLine(c - b + 2);
}