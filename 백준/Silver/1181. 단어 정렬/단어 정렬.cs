using System.Text;

StringBuilder sb = new StringBuilder();

 int a = int.Parse(Console.ReadLine());

 string[] arr = new string[a];

 for (int i = 0; i < a; i++)
 {
     string b = Console.ReadLine();
     if (arr.Contains(b))
         continue;
     arr[i] = b;
 }
 Array.Sort(arr);
 for (int i = 0; i < 51; i++)
 {
     foreach (string j in arr)
     {
         if(j != null)
             if (j.Length == i)
             {
                 sb.AppendLine(j);
             }
     }
 }
 Console.WriteLine(sb);