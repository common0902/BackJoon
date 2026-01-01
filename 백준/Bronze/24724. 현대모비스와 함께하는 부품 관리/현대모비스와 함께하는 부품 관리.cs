int a = int.Parse(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    int b = int.Parse(Console.ReadLine());
    Console.ReadLine(); 
    for (int j = 0; j < b; j++)
        Console.ReadLine(); 

    Console.WriteLine($"Material Management {i}");
    Console.WriteLine("Classification ---- End!");
}