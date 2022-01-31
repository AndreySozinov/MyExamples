Console.Clear();

int a = new Random().Next(0, 100);
int b = new Random().Next(0, 100);
int c = new Random().Next(0, 100);
int d = new Random().Next(0, 100);
int e = new Random().Next(0, 100);

Console.Write(a);
Console.Write(" ");
Console.Write(b);
Console.Write(" ");
Console.Write(c);
Console.Write(" ");
Console.Write(d);
Console.Write(" ");
Console.WriteLine(e);

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);
