using System;

class Contact
{
    public string name;
    public int age;
    public string vocation;

    public void ContactDetails()
    {
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();

        Console.WriteLine("How old are you?");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is your vocation?");
        vocation = Console.ReadLine();

        Console.WriteLine($"{name} \n{age} \n{vocation}");
    }
}