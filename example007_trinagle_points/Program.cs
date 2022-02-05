Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+ a");

// int xa = 40;
// int ya = 1;
// int xb = 1;
// int yb = 20;
// int xc = 80;
// int yc = 20;

int xa = 40, ya = 1, 
    xb = 0, yb = 30, 
    xc = 90, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;

int count = 0;

while (count < 10000)
{
    int position = 0; // Exclude the top a on the first iteration
    if (count == 0)
    {
        position = 1;
    }
    int what = new Random().Next(position, 3); 
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}