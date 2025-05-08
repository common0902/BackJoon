int a = int.Parse(Console.ReadLine());
    
for(int i =0;i<a; i++)
{
    int[] bc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    int b = bc[0];
    int c = bc[1];

    

    Console.WriteLine(b+c);
}