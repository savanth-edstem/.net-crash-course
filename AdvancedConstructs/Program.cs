//methods
void Add(int a , int b)
{
    Console.WriteLine($"The sum value {a + b}");
}
Add(1,2);

int GreaterThan(int a, int b, int c)
{
    int largest = a;
    if (b > largest)
    {
        largest = b;
    }
    if (c > largest)
    {
        c = largest;
    }
    return largest;
}
int largest = GreaterThan(10, 15, 8);
Console.WriteLine($"Largest number is {largest}");
