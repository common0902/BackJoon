int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
int a = arr1[0];
int b = arr1[1];

int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int num1 = 1000000000;
int num2 = 0;
int wjdekq = 0;

for (int i = 0; i < arr2.Length; i++)
{
    if (num2 == b) break;

    for (int j = 0; j < arr2.Length; j++)
    {
        if (num2 == b) break;

        if (i == j) continue;

        for (int k = 0; k < arr2.Length; k++)
        {
            if (i == k || j == k) continue;

            num2 = arr2[i] + arr2[j] + arr2[k];

            if(num2 > b) continue;

            if (num1 > b - num2)
            {
                num1 = b - num2;
                wjdekq = num2;
            }
        }
    }
}
Console.WriteLine(wjdekq);