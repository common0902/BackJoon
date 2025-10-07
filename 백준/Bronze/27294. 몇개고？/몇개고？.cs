int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = ab[0]; // 시간
int b = ab[1]; // 술 여부

if (a >= 12 && a <= 16 && b == 0)
    Console.WriteLine(320);
else
    Console.WriteLine(280);