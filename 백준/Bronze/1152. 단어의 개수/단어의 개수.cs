string[] str = Console.ReadLine().Split();
if (str[str.Length - 1] == string.Empty && str[0] == string.Empty)
{
    Console.WriteLine(str.Length - 2);
}
else if (str[str.Length - 1] == string.Empty)
{
    Console.WriteLine(str.Length - 1);
}
else if (str[0] == string.Empty)
{
    Console.WriteLine(str.Length - 1);
}
else
{
    Console.WriteLine(str.Length);
}
