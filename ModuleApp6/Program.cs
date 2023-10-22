using System;
using System.ComponentModel.Design;
using System.Data;

class Book
{
    public string Name;
    public string Author;
}
class BookCollection
{
    private Book[] collection;
    public BookCollection(Book[] collection)
    {
        this.collection = collection;
    }
    public Book this [int index]
    {
        get
        {
            if(index >= 0 && index < collection.Length) 
            {
                return collection[index];      
            }
            else
            {
                return null;
            }
        }
        private set
        {
            if (index >= 0 && index < collection.Length)
            {
                collection[index] = value;
            }
        }
    }
    public Book this[string name]
    {
        get
        {
            for(int i = 0; i < collection.Length; i++)
            {
                if (collection[i].Name == name)
                {
                    return collection[i];
                }
            }
            return null;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        var array = new Book[]
        {
            new Book
            {
                Name = "Мастер и Маргарита",
                Author = "М. А. Булгаков"
            },
            new Book
            {
                Name = "Отцы и дети",
                Author = "И. С. Тургенев"
            },
        };
        BookCollection collection = new BookCollection(array);
        Book book1 = collection[0];
        Book book2 = collection[1];
        var array1 = new Book[]
        {
            new Book{ Name = "Мастер и Маргарита", Author = "М. А. Булгаков"},
            new Book{ Name = "Отцы и дети", Author = "И. С. Тургенев"},
        };
        BookCollection collection1 = new BookCollection(array1);
        Book book3 = collection1[0];
        Book book4 = collection1[1];
        Book book5 = collection["Мастер и Маргарита"];
        Console.ReadKey();


    }
}
