int a = int.Parse(Console.ReadLine());

for (int i = 1; i < a+1; i++)
{
    int[] bc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    int b = bc[0];
    int c = bc[1];

    Console.WriteLine($"Case #{i}: {b+c}");
}