int a = 781;
int b = 2;
int c = 3333;
int d = 137;
int e = 187;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine("The maximum number is ");
Console.Write(max);
