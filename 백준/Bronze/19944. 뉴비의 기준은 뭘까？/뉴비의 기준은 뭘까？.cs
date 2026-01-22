int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = arr[0];
int b = arr[1];

if (b <= 2) Console.WriteLine("NEWBIE!");
else if (b <= a) Console.WriteLine("OLDBIE!");
else Console.WriteLine("TLE!");