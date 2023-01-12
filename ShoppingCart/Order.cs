class Order
{
    private double _tax=0.01;//10 percent
    public double GetTotalPrice(double sumPrice)
    {
        double totalPrice = sumPrice+sumPrice*_tax;
        return totalPrice;
    }
}