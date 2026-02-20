string[] arr = Console.ReadLine().Split();

int a = int.Parse(arr[0]);
int b = int.Parse(arr[2]);
int c = int.Parse(arr[4]);

if (a + b == c)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");