using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Time
{
    class OrderProcessing
    {
        public static void ProcessTheOrder(Order order, Menu pizza)
        {
            order.MakeAnOrder(pizza);
            order.CookThePizza();
            order.SetReady();
        }
    }
}
