int n = int.Parse(Console.ReadLine()); 

for (int i = 0; i < n; i++)
{
    int[] abc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int a = abc[0]; 
    int b = abc[1]; 
    int c = abc[2]; 

    int w = a * (c - 1) + b;
    Console.WriteLine(w);
}