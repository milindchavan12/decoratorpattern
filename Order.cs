using System;
using System.Collections.Generic;
using System.Linq;

namespace DecoratorPattern
{
    //Contrete Class
    public class Order : OrderBase
    {
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a regular order");
            return products.Sum(x => x.Price);
        }
    }
}