int[] arr1 = { 1, 1, 2, 2, 2, 8 };  // 킹, 퀸, 룩, 비숍, 나이트, 폰
string[] arr2 = Console.ReadLine().Split(' ');
int[] arr3 = Array.ConvertAll(arr2, int.Parse);

for (int i = 0; i < arr1.Length; i++)
{
    Console.Write(arr1[i] - arr3[i]);
    if (i < arr1.Length - 1)
        Console.Write(" ");
}