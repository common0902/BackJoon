int[] arr = Array.ConvertAll(Console.ReadLine().Split('/'), int.Parse);
int a = arr[0], D = arr[1], A = arr[2];

Console.WriteLine((D == 0 || a + A < D) ? "hasu" : "gosu");