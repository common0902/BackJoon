int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int a = arr[0];
int b = arr[1];
int c = arr[2];
int d = arr[3];
int e = arr[4];
int f = arr[5];
int g = arr[6];
int h = arr[7];
int i = arr[8];

if (100 > a + b + c + d + e + f + g + h + i)
{
    Console.WriteLine("none");
}
else if (a > 100 || b > 100 || c > 200 || d > 200 || e > 300 || f > 300 || g > 400 || h > 400 || i > 500)
{
    Console.WriteLine("hacker");
}
else
{
    Console.WriteLine("draw");  
}