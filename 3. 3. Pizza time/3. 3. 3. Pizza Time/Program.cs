using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Boris = new Customer("Boris");
            Customer otherBoris = new Customer("Boris");
            Customer kitten = new Customer("kittenn");

            Order BorisOrder = new Order(Boris);
            Order otherBorisOrder = new Order(otherBoris);
            Order kittensOrder = new Order(kitten);

            OrderProcessing.ProcessTheOrder(BorisOrder, Menu.Neapolitan);
            OrderProcessing.ProcessTheOrder(otherBorisOrder, Menu.Greek);
            OrderProcessing.ProcessTheOrder(kittensOrder, Menu.Pepperoni);
        }
    }
}
