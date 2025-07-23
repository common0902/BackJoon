int a = int.Parse(Console.ReadLine());

int count = 0;

bool can = true;

while (true)
{
    if (a == 0) break;
    
    if (a < 0)
    {
        can = false;
        break;
    }

    if (a % 5 == 0) a -= 5;
    else a -= 3;


    count++;
}
if(can) Console.WriteLine(count);
else Console.WriteLine(-1);