using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{

    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(20, 30);
            Console.WriteLine("X: {0}, Y: {1}", point.X, point.Y);
            point.Move(30, 40);
            Console.WriteLine("X: {0}, Y: {1}", point.X, point.Y);
            point.Move(new Point(50, 100));
            Console.WriteLine("X: {0}, Y: {1}", point.X, point.Y);
        }
    }
}
