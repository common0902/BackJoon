while(true)
{
    int[] bc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    int b = bc[0];
    int c = bc[1];

    if (b == 0 && c == 0) break;

    Console.WriteLine(b+c);
}