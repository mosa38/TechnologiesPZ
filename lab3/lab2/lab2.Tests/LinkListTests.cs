using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace lab2.Tests
{
    [TestClass]
    public class LinkListTests
    {
        [TestMethod]
        public void Count_3()
        {
            int a = 3;
            LinkList<int> ll = new LinkList<int>();
            ll.AddAtTail(1);
            ll.AddAtTail(2);
            ll.AddAtTail(3);
            Assert.AreEqual(a, ll.Count);
        }
        [TestMethod]
        public void Count_zero()
        {
            int a = 0;
            LinkList<int> ll = new LinkList<int>();
            Assert.AreEqual(a, ll.Count);
        }
        [TestMethod]
        public void RavenstvoKolichestvoElementovDvoxListov()
        {
            LinkList<int> ll = new LinkList<int>();
            LinkList<int> ll1 = new LinkList<int>();
            for (int i = 1; i < 6; i++) { ll.AddAtTail(i); }
            ll.AddAfter(5, 2);
            for (int i = 1; i < 7; i++) { ll1.AddAtTail(i); }            
            Assert.AreEqual(ll.Count, ll1.Count);
        }
        [TestMethod]
        public void RavenstvoPervixElementovDvoxListov()
        {
            LinkList<int> ll = new LinkList<int>();
            LinkList<int> ll1 = new LinkList<int>();
            for (int i = 1; i < 6; i++) { ll.AddAtTail(i); }
            for (int i = 2; i < 6; i++) { ll1.AddAtTail(i); }
            Assert.AreNotEqual(ll.Head.item, ll1.Head.item);
        }
        [TestMethod]
        public void EmptyListAfterDelete()
        {
            LinkList<int> ll = new LinkList<int>();
            for (int i = 1; i < 6; i++) { ll.AddAtTail(i); }
            for (int i = 1; i < 6; i++) { ll.DeleteNode(i); }
            Assert.IsNull(ll.Head);
        }
    }
}
