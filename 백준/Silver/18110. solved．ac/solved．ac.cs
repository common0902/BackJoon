 int a = int.Parse(Console.ReadLine());

 int b = 0;
 float c = 0;

 int[] arr = new int[a];

 for (int i = 0; i < a; i++)
 {
     b = int.Parse(Console.ReadLine());
     arr[i] = b;
 }

 Array.Sort(arr);

 c = MathF.Round(a * 0.15f,0 , MidpointRounding.AwayFromZero);

 a -= (int)c * 2;
 
for (int i = 0; i < c; i++)
 {
     arr[i] = 0;
     arr[arr.Length - 1 - i] = 0;
 }

 float num = 0;

 foreach (int i in arr)
 {
     num += i;
 }

 c = MathF.Round(num / a,0, MidpointRounding.AwayFromZero);

 if(a == 0)
     Console.WriteLine(0);
 else
     Console.WriteLine(c);