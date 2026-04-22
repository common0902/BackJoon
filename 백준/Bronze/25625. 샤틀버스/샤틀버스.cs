int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = arr[0];
int b = arr[1];

if (b <= a)
    Console.WriteLine(a + b);
else
    Console.WriteLine(b - a);