using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Node<T>
    {
        public T item;
        public Node<T> next;
        public Node()
        {
            next = null;
        }
        public Node(T item)
        {
            if (item == null)
                throw new ArgumentNullException();
            this.item = item;
        }
    }
}
