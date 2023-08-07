using ChainOfRespPatternApp.DiscountChainResp;
using ChainOfRespPatternApp.Orders;

namespace ChainOfRespPatternApp.Discounts;

public class OrderAmount : DiscountChain
{
    public override double Handle(Order order)
    {
         if (order.Amount > 1000)
        {
            var discount = order.Size * (0.10);
            return discount;
        }  

        return 0 ; //base.Handle(order);
    }
}