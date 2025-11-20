int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int a = arr2[0] - arr1[2];
int b = arr2[1] / arr1[1];
int c = arr2[2] - arr1[0];

Console.WriteLine($"{a} {b} {c}");