int[] ab = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

int num = 0;

for (int i = 0; i < ab.Length; i++)
{
    num += ab[i];
}

Console.WriteLine(num);
