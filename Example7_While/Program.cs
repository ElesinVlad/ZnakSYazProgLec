﻿Console.Clear();
int xa=40, ya=1,   
    xb=1, yb=15,
    xc=80, yc=15;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
int x = xa, y = xb;
int count = 0;
while (count++ <10000)
{
    int what = new Random().Next(0, 3);
    switch (what)
    {
        case 0:
            {
                x = (x+xa)/2;
                y= (y+ya)/2;
                break;
            }
        case 1:
            {
                x = (x+xb)/2;
                y= (y+yb)/2;
                break;
            }
        case 2:
            {
                x = (x+xc)/2;
                y= (y+yc)/2;
                break;
            }
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
} 
//Console.WriteLine("Hello, World!");
