int a = int.Parse(Console.ReadLine());
int[] bc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int b = bc[0]; 
int c = bc[1]; 

int num = b / c; 

if (num >= a)
    Console.WriteLine(1);
else
    Console.WriteLine(0);