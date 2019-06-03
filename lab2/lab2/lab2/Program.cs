using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var link = new LinkList<int>();
            Console.WriteLine("Автор: Мосьпак Олег, Группа: IC-63, Вариант:10, Связанный список");
            link.AddNode += new EventHandler(MessageShow);
            link.DisplayList();
            Console.WriteLine("Добавляем элементы в список:");
            for (int i = 1; i < 6; i++) { link.AddAtTail(i); }
            link.DisplayList();
            int h = 6, t = 5;
            Console.WriteLine("Добавим " + h + " после " + t);
            link.AddAfter(h, t);
            link.DisplayList();
            Console.WriteLine("Удалим 1,2,3,4,5," + h);
            for (int i = 1; i < 6; i++) { link.DeleteNode(i); }
            link.DeleteNode(h);
            link.DisplayList();
            Console.WriteLine("\nГотово)");
            Console.ReadLine();
        }
        static void MessageShow(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }
    }
}
