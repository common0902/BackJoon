int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(arr2);
Console.WriteLine(arr2[arr2.Length - arr1[1]]);