ShoppingCartEntry item1 = new ShoppingCartEntry("Iphone",500,1);
ShoppingCartEntry item2 = new ShoppingCartEntry("MacBook",1500,2);
ShoppingCartEntry item3 = new ShoppingCartEntry("S 22 Ultra",400,3);
ShoppingCartEntry item4 = new ShoppingCartEntry("Google Pixel",400,4);
ShoppingCartEntry item5 = new ShoppingCartEntry("Smart watch",200,5);
ShoppingCartList shoppingCartList = new ShoppingCartList();

void AddProductToCart()
{
   
    shoppingCartList.AddToCart(item1);
    shoppingCartList.AddToCart(item2);
    shoppingCartList.AddToCart(item3);
    shoppingCartList.AddToCart(item4);
    shoppingCartList.AddToCart(item5);   
}
void TotalPrice(){
    Order order= new Order();
    double totalPrice = shoppingCartList.TotalPriceCalculation();
    Console.WriteLine(order.GetTotalPrice(totalPrice));
}
try
{
    AddProductToCart();
    shoppingCartList.PrintCart();
    TotalPrice();
}
catch (Exception)
{

    throw;
}
finally
{
    Console.WriteLine("   Thank You");
}