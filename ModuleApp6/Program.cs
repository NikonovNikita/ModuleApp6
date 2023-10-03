using System;
using System.Data;

class User
{
    private int age;
    private string login;
    private string email;

    public string Login
    {
        get
        {
            return login;
        }
        set
        {
            if (value.Length < 3)
            {
                Console.WriteLine("Логин не может быть менее 3 символов!");
            }
            else
            {
                login = value;
            }
        }
    }

    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            if (!value.Contains('@'))
            {
                Console.WriteLine("Неверный формат адреса почты!");
            }
            else
            {
                email = value;
            }
        }
    }

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 18)
            {
                Console.WriteLine("Возраст должен быть не меньше 18!");
            }
            else
            {
                age = value;
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        User user = new();
        user.Age = 21;
        Console.WriteLine(user.Age);

    }
}