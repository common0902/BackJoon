int a = int.Parse(Console.ReadLine());

Queue<int> queue = new Queue<int>();

int count = 0;

for (int i = 1; i <= a; i++)
{
    queue.Enqueue(i);
}

while (true)
{
    if (queue.Count == 1) break;

    if (count % 2 == 0)
    {
        queue.Dequeue();
    }
    else
    {
        int b = queue.Dequeue();
        queue.Enqueue(b);
    }
    count++;
}
Console.WriteLine(queue.Dequeue());