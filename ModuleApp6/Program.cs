using System;
using System.Data;

struct Data
{
    public string Name;
    public int Length;
    public int Version;
    public int[] Array;
}
class Obj
{
    public string Name;
    public bool IsAlive;
    public int Weight;
}
class Program
{
    static void Main(string[] args)
    {
        Data data = new() { Name = "Запись", Length = 10, Version = 1, Array = new int[] {15, 30} };
        Obj obj = new() { Name = "Стол", IsAlive = false, Weight = 15 };
        
        var dataCopy = data;
        var objCopy = obj;

        data.Name = "Значение";
        data.Length = 35;
        data.Version = 2;
        data.Array[0] = 0;
        dataCopy.Name = "Проверка";

        obj.Name = "Кот";
        obj.IsAlive = true;
        obj.Weight = 3;

        objCopy = new Obj { Name = obj.Name, IsAlive = obj.IsAlive, Weight = obj.Weight };

        obj.Name = "Стол";
        obj.IsAlive = false;
        obj.Weight = 15;

        Console.ReadKey();
    }
}