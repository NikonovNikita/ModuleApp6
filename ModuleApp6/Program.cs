using System;
using System.ComponentModel.Design;
using System.Data;

static class IntExtensions
{
    public static int GetNegative(this int number)
    {
        if(number < 0)
        {
            return number;
        }
        else
        {
            return - number;
        }
    }
    public static int GetPositive(this int number)
    {
        if (number > 0)
        {
            return number;
        }
        else
        {
            return - number;
        }
    }
    public static void Main(string[] args)
    {
        int num1 = 7;
        int num2 = -13;
        int num3 = 0;

        Console.WriteLine(num1.GetPositive());
        Console.WriteLine(num1.GetNegative());
        Console.WriteLine(num2.GetPositive());
        Console.WriteLine(num2.GetNegative());
        Console.WriteLine(num3.GetPositive());
        Console.WriteLine(num3.GetNegative());
    }
}
