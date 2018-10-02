using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            //BOXING
            object obj = number;

            //UNBOXING
            int numberTwo = (int)obj;


            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("String");
            //list.Add(DateTime.Today);

            //var number = (int)list[1];

            //var anotherList = new List<int>();
            //var names = new List<string>();
        }
    }
}
