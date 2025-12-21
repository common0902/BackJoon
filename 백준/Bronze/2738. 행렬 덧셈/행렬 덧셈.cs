using System.Text;  

StringBuilder sb = new StringBuilder();

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int a = arr[0];
int b = arr[1];

int[,] arr2 = new int[a,b];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < a; j++)
    {
        int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int k = 0; k < b; k++)
        {
            arr2[j,k] += arr1[k];
        }
    }
}
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        sb.Append(arr2[i,j]+ " ");
    }
    sb.AppendLine();
}
Console.WriteLine(sb);