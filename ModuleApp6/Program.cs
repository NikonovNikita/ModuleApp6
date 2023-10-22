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

    }
}
