using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class LinkList<T> : ICollection<T>, IEnumerable<T>
    {
        public event EventHandler AddNode;
        public Node<T> Head { get; set; }
        public int Count
        {
            get
            {
                int i = 0;
                Node<T> newNode = new Node<T>();
                if (this.Head == null)
                {
                    i = 0;
                }
                else
                {
                    Node<T> temp = this.Head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                        i++;
                    }
                    i++;
                }
                return i;
            }
        }
        public bool IsReadOnly
        { get { throw new NotImplementedException(); } }

        public LinkList()
        {
            this.Head = null;
        }

        public void AddAtTail(T item)
        {
            Node<T> newNode = new Node<T>();
            newNode.item = item;
            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                Node<T> temp = this.Head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            if (AddNode != null)
                AddNode(sender: "Новый элемент: " + newNode.item, e: EventArgs.Empty);
        }
        public void AddAfter(T item, T item2)
        {
            Node<T> newNode = new Node<T>();
            newNode.item = item;
            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                Node<T> temp = Head;
                Node<T> tempPre = Head;
                Node<T> tempNext = Head;
                bool matched = false;
                while (!(matched = temp.item.Equals(item2)) && temp.next != null)
                {
                    tempPre = temp;
                    temp = temp.next;
                    tempNext = temp.next;

                }
                if (matched)
                {
                    temp.next = newNode;
                    newNode.next = tempNext;
                }
            }
            if (AddNode != null)
                AddNode(sender: "Новый элемент: " + newNode.item, e: EventArgs.Empty);
        }
        public void DeleteNode(T item)
        {
            if (this.Head.item.Equals(item))
            {
                Head = Head.next;
            }
            else
            {
                Node<T> temp = Head;
                Node<T> tempPre = Head;
                bool matched = false;
                while (!(matched = temp.item.Equals(item)) && temp.next != null)
                {
                    tempPre = temp;
                    temp = temp.next;
                }
                if (matched)
                {
                    tempPre.next = temp.next;
                }
                else
                {
                    Console.WriteLine("Значение не найдено!");
                }
            }
        }
        public void DisplayList()
        {
            Console.WriteLine("Список:");
            Node<T> temp = this.Head;
            try
            {
                do
                {
                    Console.WriteLine(temp.item);
                    temp = temp.next;
                }
                while (temp != null);
            }
            catch (Exception)
            {
                Console.WriteLine("Список пуст");
            }
        }
        public void AddAtHead(T item)
        {
            Node<T> newNode = new Node<T>();
            newNode.item = item;
            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                newNode.next = Head;
                this.Head = newNode;
            }
            if (AddNode != null)
                AddNode(sender: "Новый элемент: " + newNode.item, e: EventArgs.Empty);
        }
        public void RemoveAll()
        {
            try
            {
                Node<T> temp = Head;
                Node<T> tempPre = Head;
                while (temp.next != null)
                {
                    tempPre = temp;
                    temp = temp.next;
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Нельзя удалить,список пуст");
            }
        }
        public bool searchNode(T item)
        {
            Node<T> temp = this.Head;
            bool matched = false;
            while (!(matched = temp.item.Equals(item)) && temp.next != null)
            {
                temp = temp.next;
            }
            return matched;
        }
        public IEnumerator<T> GetEnumerator()
        {
            var temp = Head;
            while (temp != null)
            {
                yield return temp.item;
                temp = temp.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>();
            newNode.item = item;
            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                Node<T> temp = this.Head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            if (AddNode != null)
                AddNode(sender: "Новый элемент: " + newNode.item, e: EventArgs.Empty);
        }

        public void Clear()
        {
            try
            {
                Node<T> temp = Head;
                Node<T> tempPre = Head;
                while (temp.next != null)
                {
                    tempPre = temp;
                    temp = temp.next;
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Нельзя удалить,список пуст");
            }
        }

        public bool Contains(T item)
        {
            Node<T> temp = this.Head;
            bool matched = false;
            while (!(matched = temp.item.Equals(item)) && temp.next != null)
            {
                temp = temp.next;
            }
            return matched;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            if (this.Head.item.Equals(item))
            {
                Head = Head.next;
                return true;
            }
            else
            {
                Node<T> temp = Head;
                Node<T> tempPre = Head;
                bool matched = false;
                while (!(matched = temp.item.Equals(item)) && temp.next != null)
                {
                    tempPre = temp;
                    temp = temp.next;
                }
                if (matched)
                {
                    tempPre.next = temp.next;
                }
                else
                {
                    Console.WriteLine("Значение не найдено!");
                }
                return matched;
            }

        }
    }
}
