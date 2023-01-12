//immutable
class User
{
    //construction
    public User(string firstName, string lastName, int age,double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        _salary= salary;

    }
    public String FirstName { get;}
    public String LastName { get;  }
    public int Age { get; }
    private double _salary;
}