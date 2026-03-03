int a = int.Parse(Console.ReadLine());

string[] arr = new string[a];
string[] arr2 = new string[a];

for (int i = 0; i < a; i++)
{
    arr[i] = Console.ReadLine();
    arr2[i] = arr[i];
}

Array.Sort(arr2);

bool INCREASING = true;

for (int i = 0; i < a; i++)
{
    if (arr[i] != arr2[i])
    {
        INCREASING = false;
    }
}

Array.Reverse(arr2);

bool DECREASING = true;

for (int i = 0; i < a; i++)
{
    if (arr[i] != arr2[i])
    {
        DECREASING = false;
    }
}

if( INCREASING )
    Console.WriteLine("INCREASING");
else if( DECREASING )
    Console.WriteLine("DECREASING");
else
    Console.WriteLine("NEITHER");