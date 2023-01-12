string firstName = string.Empty;
string lastName = string.Empty;
string middleName = string.Empty;
int age = 0;
double salary = 0.0;

Console.Write("Enter first name ");
firstName = Console.ReadLine();

Console.Write("Enter last name ");
lastName = Console.ReadLine();

Console.Write("Enter age ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter salary ");
salary = Convert.ToDouble(Console.ReadLine());

Person person = new Person();
person.FirstName = firstName;
person.LastName = lastName;
person.Age = age;
person.SetSalary(salary);

User theUser = new User(firstName, lastName, age, salary);

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"The name entered is {person.GetFullName()}");
}
else
{
    Console.WriteLine($"The name entered is {person.GetFullName(middleName)}");
}
Console.WriteLine($"The salary entered is {person.GetSalary()}");

Triangle triangle = new Triangle() { Height = 10, Width = 5 };
Rectangle rectangle = new Rectangle() { Height = 10, Width = 5 };
Rectangle square = new Rectangle() { Height = 10, Width = 5 };