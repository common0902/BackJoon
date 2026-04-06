using System.Text;

StringBuilder sb = new StringBuilder();
Queue<int> queue = new Queue<int>();
int num = 0;

int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; ++i)
{
    string[] arr = Console.ReadLine().Split(' ');
    string b = arr[0];

    switch (b)
    {
        case "push":
            int x = int.Parse(arr[1]);
            queue.Enqueue(x);
            num = x;
            break;

        case "pop":
            if (queue.Count == 0)
                sb.AppendLine("-1");
            else
                sb.AppendLine(queue.Dequeue().ToString());
            break;

        case "size":
            sb.AppendLine(queue.Count.ToString());
            break;

        case "empty":
            if (queue.Count == 0)
                sb.AppendLine("1");
            else
                sb.AppendLine("0");
            break;

        case "front":
            if (queue.Count == 0)
                sb.AppendLine("-1");
            else
                sb.AppendLine(queue.Peek().ToString());
            break;

        case "back":
            if (queue.Count == 0)
                sb.AppendLine("-1");
            else
                sb.AppendLine(num.ToString());
            break;
    }
}

Console.WriteLine(sb);