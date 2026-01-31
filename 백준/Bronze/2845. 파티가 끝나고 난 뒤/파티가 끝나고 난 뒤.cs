int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = arr[0];
int b = arr[1];

int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

foreach (int i in arr2)
    Console.Write((i - a * b) + " ");