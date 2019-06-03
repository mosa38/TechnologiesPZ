using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Krug
    {
        private double pi = 3.14;
        private int r = 3;
        private int d = 4;
        public void Write()
        {
            Console.WriteLine("Круг:");
            Console.WriteLine("Радиус - " + r + "\nДиаметр - " + d);
            Console.WriteLine("Периметр - " + (2 * pi * r));
            Console.WriteLine("Площадь - " + (pi * Math.Pow(r, 2)));
        }
    }
}
