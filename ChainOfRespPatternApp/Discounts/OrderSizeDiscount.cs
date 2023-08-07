using ChainOfRespPatternApp.DiscountChainResp;
using ChainOfRespPatternApp.Orders;

namespace ChainOfRespPatternApp.Discounts;

public class OrderSizeDiscount : DiscountChain
{

    public override double Handle(Order order)
    {
        double discount = 0;
        if(order.Size > 100)
        {
            discount = order.Size * (0.30);
            return discount;
        }
       
               return base.Handle(order);
       
    }
}