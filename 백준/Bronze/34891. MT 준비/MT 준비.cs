int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = arr[0];
int b = arr[1];

if (a == 0)
    Console.WriteLine(0);
else
    Console.WriteLine((a + b - 1) / b);