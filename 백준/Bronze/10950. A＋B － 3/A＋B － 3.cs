int a = int.Parse(Console.ReadLine());

while (a != 0)
{
    int[] bc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int b = bc[0];
    int c = bc[1];
    Console.WriteLine(b + c);
    --a;
}