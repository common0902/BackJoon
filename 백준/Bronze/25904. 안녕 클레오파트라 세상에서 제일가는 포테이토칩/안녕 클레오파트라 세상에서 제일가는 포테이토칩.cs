int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = arr[0];
int b = arr[1];

int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int num = b;
int index = 0;

while (true)
{
    if (num > arr1[index])
    {
        Console.WriteLine(index + 1);
        break;
    }

    num++;
    index = (index + 1) % a;
}