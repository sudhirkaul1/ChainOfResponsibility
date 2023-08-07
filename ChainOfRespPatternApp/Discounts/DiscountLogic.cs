using ChainOfRespPatternApp.Orders;

namespace ChainOfRespPatternApp.Discounts;

public class DiscountLogic
{
    public double Discount { get; set; }
    public double ApplyDiscount(Order order)
    {
        if(order.Size > 100)
        {
            Discount = order.Size * (0.30);
            return Discount;
        }

        if(order.Size > 50 && order.Amount > 2000)
        {
             Discount = order.Size * (0.20);
             return Discount;
        }

        if (order.Amount > 1000)
        {
            Discount = order.Size * (0.10);
            return Discount;
        }   

        return 0;





    }
}