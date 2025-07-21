int a = int.Parse(Console.ReadLine());
int A = a;

int count = 0;

int num = 0;

while (true)
{
    int x = a / 10;
    int y = a % 10;
    num = x + y;
    num = num % 10;
    string NUM = num.ToString();
    a = int.Parse(y.ToString() + NUM[0]);
    count++;
    if (a == A) break;

}
Console.WriteLine(count);