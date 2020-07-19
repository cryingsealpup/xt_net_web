using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pizza_Time
{
    public enum Menu
    {
        None, Pepperoni, Greek, Neapolitan, Fugazzetta, Margherita, Matzah
    }

    class Order
    {
        public delegate void OrdersHandler(Menu order);
        public event OrdersHandler OnMakeOrder;
        public event OrdersHandler OnGetOrder;
        public event OrdersHandler OnCookOrder;
        Customer customer;
        static Menu pizza;
        public Order(Customer customerCurrent)
        {
            customer = customerCurrent;
        }
        public void MakeAnOrder(Menu pizzaOrdered)
        {
            OnMakeOrder?.Invoke(pizzaOrdered);
            pizza = pizzaOrdered;
            Thread.Sleep(new Random().Next(1000, 3000));
            Console.WriteLine("{0} {1}: order accepted!", customer.id, customer.name);
        }

        public void CookThePizza()
        {
            OnCookOrder?.Invoke(pizza);
            Console.WriteLine("{0} {1} | cooking...", customer.id, customer.name);
            Thread.Sleep(new Random().Next(1000, 3000));
        }

        public void SetReady()
        {
            OnGetOrder?.Invoke(pizza);
            OnMakeOrder?.Invoke(pizza);
            Console.WriteLine("{0} {1}, your order {2} is up!", customer.id, customer.name, pizza.ToString());
            Console.WriteLine(Environment.NewLine);
        }

    }
}
