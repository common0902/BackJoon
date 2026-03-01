using System.Text;

StringBuilder sb = new StringBuilder();

int a = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Array.Sort(arr);

foreach (int i in arr)
{
    sb.Append(i + " ");
}
Console.WriteLine(sb);