﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Amazon
{

    public class RateCalculator
    {
        public int Calculate(Customer customer)
        {
            return 0;
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            Console.WriteLine("");
        }
    }
}
