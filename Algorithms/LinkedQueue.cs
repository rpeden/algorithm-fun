using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    //Queue backed by a linked list
    public class LinkedQueue<T>
    {
        private Node _first;
        private Node _last;
        private int _length = 0;
        public int Length 
        {
            get 
            {
                return _length;
            }
        }

        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        public void Enqueue(T item)
        {
            var newNode = new Node {
                Data = item,
                Next = null
            };

            if(IsEmpty())
            {
                _first = newNode;
                _last = newNode;
            }
            else
            {
                _last.Next = newNode;
                _last = newNode;
            }
            _length++;
        }

        public T Dequeue()
        {
            if (IsEmpty()) return default(T);
            var head = _first;
            if(head.Next == null)
            {
                _first = null;
                _last = null;
            } 
            else
            {
                _first = head.Next;
            }
            _length--;
            return head.Data;          
        }

        private bool IsEmpty()
        {
            return _length == 0;
        }
    }

    [TestFixture]
    public class LinkedQueueTests
    {

        [Test]
        public void TestQueueStrings()
        {
            var testItems = new string[] 
            {
                "item1",
                "item2",
                "item3"
            };

            TestQueue<string>(testItems);
        }

        [Test]
        public void TestQueueInts()
        {
            var testItems = new int[] { 11, 2, 56, 12 };
            TestQueue<int>(testItems);
        }

        [Test]
        public void TestQueueReferenceTypes()
        {
            var testItems = new DateTime[] 
            {
                DateTime.Now,
                DateTime.UtcNow,
                DateTime.Now.AddDays(-10),
                DateTime.Now.AddYears(-1000),
                DateTime.Now.AddTicks(1000)
            };

            TestQueue<DateTime>(testItems);
        }

        private void TestQueue<T>(T[] items)
        {
            dynamic queue = new LinkedQueue<T>();

            foreach(var item in items)
            {
                queue.Enqueue(item);
            }

            Assert.AreEqual(items.Length, queue.Length);

            foreach(var item in items)
            {
                Assert.AreEqual(item, queue.Dequeue());
            }

            Assert.AreEqual(0, queue.Length);
        }
    }
}
