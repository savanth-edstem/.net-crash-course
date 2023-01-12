class Person
{
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public int Age { get; set; }
    private double _salary;
    public void SetSalary(double salary)
    {
        _salary = salary;
    }
    public double GetSalary()
    {
        return _salary;
    }

    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
    public string GetFullName(string middleName)
    {
        return FirstName + " " + middleName + " " + LastName;
    }
}