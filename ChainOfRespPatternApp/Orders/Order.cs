namespace ChainOfRespPatternApp.Orders;

public class Order
{
    public int Size { get; set; }
    public int Amount { get; set; }

    public Order(int size , int amount)
    {
        Size = size;
        Amount = amount;
    }
}