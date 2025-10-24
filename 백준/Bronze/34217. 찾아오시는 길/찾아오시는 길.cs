int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int a = arr1[0];
int b = arr1[1];
int c = arr2[0];
int d = arr2[1];

int num1 = a + c;
int num2 = b + d;

if (num1 < num2)
    Console.WriteLine("Hanyang Univ.");
else if (num1 > num2)
    Console.WriteLine("Yongdap");
else
    Console.WriteLine("Either");