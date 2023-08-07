// See https://aka.ms/new-console-template for more information
using ChainOfRespPatternApp.DiscountChainResp;
using ChainOfRespPatternApp.Discounts;
using ChainOfRespPatternApp.Orders;

Console.WriteLine("Hello, World!");


Order order = new Order(100,1000);

DiscountLogic applyDiscount = new DiscountLogic();

var discount = applyDiscount.ApplyDiscount(order);

Console.WriteLine(discount);

var orderSizeDiscount = new OrderSizeDiscount();
var orderSizeAndAmount =  new OrderSizeAndAmount();
var orderAmount = new OrderAmount();

orderSizeDiscount.SetNext(orderSizeAndAmount);
orderSizeAndAmount.SetNext(orderAmount);

var x = orderSizeDiscount.Handle(order);
System.Console.WriteLine(x);