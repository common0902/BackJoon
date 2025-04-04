int[] dice = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

if (dice[0] == dice[1] && dice[1] == dice[2])
{
    Console.WriteLine(10000 + dice[0] * 1000);
}
else if (dice[0] == dice[1] || dice[0] == dice[2])
{
    Console.WriteLine(1000 + dice[0] * 100);
}
else if (dice[1] == dice[2])
    Console.WriteLine(1000 + dice[1] * 100);
else
{
    int max = dice[0];
    if (max < dice[1])
        max = dice[1];
    if (max < dice[2])
        max = dice[2];
    Console.WriteLine(max * 100);
}
