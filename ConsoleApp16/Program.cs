Console.WriteLine("Hello World! OOP");

var p = new Person("John", "Doe", new DateOnly(1990, 1, 1));


// Console.WriteLine($"{p.firstName} {p.lastName} was born on {p.birthDate}");

public class Person
{
    public Person(string firstName, string lastName, DateOnly birthDate)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDate = birthDate;
    }


    private string firstName;
    private string lastName;
    private DateOnly birthDate;
}

