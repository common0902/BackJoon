int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());

int x = A * B * C;
string X = x.ToString();
    
for (int i = 0; i < 10; i++)
{
    int count = 0;
    string I = i.ToString();

    for (int j = 0; j < X.Length; j++)
    {
        if (I[0] == X[j]) count++;
    }

    Console.WriteLine(count);
}