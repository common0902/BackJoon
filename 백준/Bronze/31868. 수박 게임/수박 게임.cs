string[] arr = Console.ReadLine().Split();
int a = int.Parse(arr[0]);
long b = long.Parse(arr[1]);

long count = 1;
for (int i = 1; i < a; i++)
    count *= 2;

Console.WriteLine(b / count);