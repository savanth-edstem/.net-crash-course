class Triangle : Shape
{
    public int Hypotenuese { get; set; }
    public double CalculateArea()
    {
        return 0.5 * Width * Height;
    }
}