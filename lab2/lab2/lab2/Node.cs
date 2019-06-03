using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Node<T>
    {
        public T item;
        public Node<T> next;
        public Node()
        {
            this.next = null;
        }
        public Node(T item)
        {
            if (item == null)
                throw new ArgumentNullException();
            this.item = item;
        }
    }
}
