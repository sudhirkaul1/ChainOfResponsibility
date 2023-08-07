using ChainOfRespPatternApp.Orders;

namespace ChainOfRespPatternApp.DiscountChainResp;

public class DiscountChain
{

    protected DiscountChain? _next;

    public DiscountChain SetNext(DiscountChain discountChain)
    {
        _next = discountChain;
        return discountChain;
    }

    public virtual double Handle(Order order)
    {
        if( _next != null)
        {
               return _next.Handle(order);
        }
        else
        {
            return 0;
        } 

    }

}