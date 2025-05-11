int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int A = arr[0];
int B = arr[1];
int C = arr[2];

Console.WriteLine((A + B) % C);
Console.WriteLine(((A % C) + (B % C)) % C);
Console.WriteLine((A*B) % C);
Console.WriteLine(((A % C) * (B % C)) % C);
