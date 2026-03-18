string a = Console.ReadLine();
string b = "";

for (int i = a.Length - 1; 0 <= i; i--)
{
    b += a[i];
}

if(a == b)
    Console.WriteLine(1);
else
    Console.WriteLine(0);