using System;

public class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Person GrowOlder()
    {
        return new Person(Name, Age + 1);
    }
}

public class Program
{
    public static void Main()
    {
        Person person = new Person("Alice", 30);

        Person olderPerson = person.GrowOlder();

       
        Console.WriteLine($"Original Age: {person.Age}");         
        Console.WriteLine($"New Age: {olderPerson.Age}");         
    }
}
