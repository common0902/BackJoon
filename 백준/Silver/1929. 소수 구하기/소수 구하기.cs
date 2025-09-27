using System.Text;

StringBuilder sb = new StringBuilder();

int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
int a = ab[0];
int b = ab[1];

for (int i = a; i <= b; i++)
{
    bool can = true;

    if (i == 1) continue;

    for (int j = 2; j <= MathF.Sqrt(i); j++)
    {
        if (i % j == 0) can = false;
    }

    if(can) sb.AppendLine(i.ToString()); 
}
Console.WriteLine(sb);