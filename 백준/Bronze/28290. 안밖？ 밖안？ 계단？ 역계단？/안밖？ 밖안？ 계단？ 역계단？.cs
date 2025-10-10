string a = Console.ReadLine();

if (a == "fdsajkl;" || a == "jkl;fdsa")
{
    Console.WriteLine("in-out");
}
else if (a == "asdf;lkj" || a == ";lkjasdf")
{
    Console.WriteLine("out-in");
}
else if (a == "asdfjkl;")
{
    Console.WriteLine("stairs");
}
else if (a == ";lkjfdsa")
{
    Console.WriteLine("reverse");
}
else
{
    Console.WriteLine("molu");
}