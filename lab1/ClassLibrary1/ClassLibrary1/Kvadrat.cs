using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Kvadrat
    {
        private int a = 3;
        public void Write()
        {
            Console.WriteLine("Квадрат:");
            Console.WriteLine("Сторона - " + a);
            Console.WriteLine("Периметр - " + (4 * a));
            Console.WriteLine("Площадь - " + (Math.Pow(a, 2)));
        }
    }
}
