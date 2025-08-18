char[] arr1 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

int[] arr2 = new int[26];

string a = Console.ReadLine()!;

int index = -1;

for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < a.Length; j++)
    {
        if (arr1[i] == a[j])
        {
            arr2[i] = j;
            break;
        }
        arr2[i] = -1;
        
    }
}
foreach (var c in arr2)
{
    Console.Write($"{c} ");
}