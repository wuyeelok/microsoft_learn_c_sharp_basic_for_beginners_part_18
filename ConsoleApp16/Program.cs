Console.WriteLine("Hello World! OOP");

var p = new Person()
{
    firstName = "John",
    lastName = "Doe",
    birthDate = new DateOnly(1980, 1, 1)
};

Console.WriteLine($"{p.firstName} {p.lastName} was born on {p.birthDate}");

public class Person
{
    public string firstName;
    public string lastName;
    public DateOnly birthDate;
}

