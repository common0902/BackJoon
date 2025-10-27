Stack<char> stack = new Stack<char> ();

string a = Console.ReadLine();

int num = 0;

bool Laser = false;

for (int i = 0; i < a.Length; i++)
{
    if (Laser)
    {
        Laser = false;
        continue;
    }

    if (a[i] == '(')
    {
        if (a[i + 1] == ')')
        {
            Laser = true;
            num += stack.Count;
        }
        else
            stack.Push('(');
    }
    else if (a[i] == ')')
    {
        num++;
        stack.Pop();
    }
}
Console.WriteLine(num);