int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int a = arr1[0];
int b = arr1[1];
int c = arr2[0];
int d = arr2[1];

int count = Math.Min(b + c, a + d);
Console.WriteLine(count);