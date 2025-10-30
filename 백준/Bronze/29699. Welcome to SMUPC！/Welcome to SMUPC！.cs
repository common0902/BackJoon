string a = "WelcomeToSMUPC";
int b = int.Parse(Console.ReadLine());
b = (b - 1) % a.Length;
Console.WriteLine(a[b]);