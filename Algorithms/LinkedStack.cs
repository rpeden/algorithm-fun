using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class LinkedStack<T>
    {
        private Node _first;
        private int _size = 0;
        public int Size 
        {
            get { return _size; }
        } 

        public void Push(T item)
        {
            var newNode = new Node()
            {
                Data = item,
                Next = _first
            };
            _first = newNode;
            _size++;
        }

        public T Pop()
        {
            if (_size == 0) return default(T);
            var previousFirst = _first;
            _first = previousFirst.Next;
            _size--;
            return previousFirst.Data;
        }

        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }
    }

    [TestFixture]
    public class LinkedStackTests
    {
        [Test]
        public void TestLinkedStrings()
        {
            dynamic stack = new LinkedStack<string>();

            var test1 = "Hi stack.";
            var test2 = "Hi again, stack";
            var test3 = "How's it going, stack?";

            stack.Push(test1);
            stack.Push(test2);
            stack.Push(test3);

            Assert.AreEqual(3, stack.Size);

            Assert.AreEqual(test3, stack.Pop());
            Assert.AreEqual(test2, stack.Pop());
            Assert.AreEqual(test1, stack.Pop());
        }

        [Test]
        public void TestLinkedInts()
        {
            dynamic stack = new LinkedStack<int>();

            var test1 = 1;
            var test2 = 2;
            var test3 = 3;

            stack.Push(test1);
            stack.Push(test2);
            stack.Push(test3);

            Assert.AreEqual(3, stack.Size);

            Assert.AreEqual(test3, stack.Pop());
            Assert.AreEqual(test2, stack.Pop());
            Assert.AreEqual(test1, stack.Pop());
        }
    }
}
