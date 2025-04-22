int n = int.Parse(Console.ReadLine()); //5
string input = Console.ReadLine(); //54321
int sum = 0;
while (n != 0)
{
    n--;
    sum += int.Parse(input[n].ToString());
}
Console.WriteLine(sum);