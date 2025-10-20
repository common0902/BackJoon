int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int[] arr3 = { 13, 7, 5, 3, 3, 2 };

double num1 = 0;
double num2 = 1.5;

for (int i = 0; i < 6; i++)
{
    num1 += arr1[i] * arr3[i];
    num2 += arr2[i] * arr3[i];
}

if (num1 > num2)
    Console.WriteLine("cocjr0208");
else
    Console.WriteLine("ekwoo");