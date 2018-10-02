﻿using System.Collections.Generic;

namespace Classes
{
    partial class Program
    {
        public class Customer
        {
            public int Id;
            public string Name;
            public List<Order> Orders;

            public Customer()
            {
                this.Orders = new List<Order>();
            }
            public Customer(int id)
                : this()
            {
                this.Id = id;
            }
            public Customer(int id, string name)
                : this(id)
            {
                this.Id = id;
                this.Name = name;
            }
        }
    }
}