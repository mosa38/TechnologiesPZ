using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Treug
    {
        private int a = 3;
        private int b = 4;
        private int c = 5;
        public void Write()
        {
            Console.WriteLine("Треугольник:");
            Console.WriteLine("Катет 1 - " + a + "\nКатет 2 - " + b + "\nГипотенуза - " + c);
            Console.WriteLine("Периметр - " + (a + b + c));
            Console.WriteLine("Площадь - " + (a * b / 2));
        }
    }
}
