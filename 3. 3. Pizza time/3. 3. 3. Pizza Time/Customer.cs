using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Time
{
    class Customer
    {
            public string name { set; get; }
            public Guid id;
            public Customer(string name)
            {
                this.id = Guid.NewGuid();
                this.name = name;
            Console.WriteLine("user {0} created", this.name);
            }
    }
}
