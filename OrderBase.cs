using System.Collections.Generic;

namespace DecoratorPattern
{
    //Component Class
    public abstract class OrderBase
    {
        protected List<Product> products = new List<Product>
        {
            new Product {Name = "Pen", Price = 10},
            new Product {Name = "Paper", Price = 2},
            new Product {Name = "Staples", Price = 15},
            new Product {Name = "Cards", Price = 5}
        };

        public abstract double CalculateTotalOrderPrice();
    }
}