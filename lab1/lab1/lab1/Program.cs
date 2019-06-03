using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kvadrat kvadrat = new Kvadrat();
            kvadrat.Write();
            Console.WriteLine();
            Krug krug = new Krug();
            krug.Write();
            Console.WriteLine();
            Treug treu = new Treug();
            treu.Write();
            Console.ReadLine();
        }
    }
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
