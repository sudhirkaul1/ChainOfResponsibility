using ChainOfRespPatternApp.DiscountChainResp;
using ChainOfRespPatternApp.Orders;

namespace ChainOfRespPatternApp.Discounts;

public class OrderSizeAndAmount : DiscountChain
{
    public override double Handle(Order order)
    {
        if(order.Size > 50 && order.Amount > 2000)
        {
             var discount = order.Size * (0.20);
             return discount;
        }
        return base.Handle(order);
    }

}