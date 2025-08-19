int a = int.Parse(Console.ReadLine());

double[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

double sum = 0;

double num = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > num) num = arr[i];
}

for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i] / num * 100;
}

Console.WriteLine(sum / a);