 int a = int.Parse(Console.ReadLine());

 string b = Console.ReadLine();
 char[] arr = new char[b.Length];

 for (int j = 0; j < b.Length; j++)
 {
     arr[j] = b[j];
 }
 for (int i = 0; i < a-1; i++)
 {
     b = Console.ReadLine();
     for (int j = 0; j < b.Length; j++)
     {
         if (arr[j] != b[j])
         {
             arr[j] = '?';
         }
     }
 }

foreach(char i in arr)
 {
     Console.Write(i);
 }