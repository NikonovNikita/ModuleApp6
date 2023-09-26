using System;
class Rectangle
{
    public int a;
    public int b;

    public int Square()
    {
        return a * b;
    }

    public Rectangle()
    {
        a = 6;
        b = 4;
    }

    public Rectangle(int side)
    {
        a = side;
        b = side;
    }

    public Rectangle(int first, int second)
    {
        a = first;
        b = second;
    }
    
}
