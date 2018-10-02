using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{

    class Program
    {
        static void Main(string[] args)
        {
            //DOWNCASTING
            Shape shape = new Text();
            //Text text = (Text)shape;
            var text = shape as Text;

            //UPCASTING
            //Text text = new Text();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);
        }
    }
}
