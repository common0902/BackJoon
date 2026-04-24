string[] arr = Console.ReadLine().Split("-");
string a = "";
for (int i = 0; i < arr.Length; ++i)
{
    a += arr[i][0];
}

Console.WriteLine(a);