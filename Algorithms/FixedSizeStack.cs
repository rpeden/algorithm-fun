using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    //A generic fixed size stack
    public class FixedSizeStack<T>
    {
        private readonly T[] _stackItems;
        private int _position = 0;

        public int Size
        {
            get
            {
                return _position;
            }
        }

        public FixedSizeStack(int size)
        {
            _stackItems = new T[size];
        }

        public void Push(T item)
        {
            _stackItems[_position++] = item;
        }

        public T Pop()
        {
            if (_position == 0) return default(T);
            return _stackItems[--_position];
        }
    }

    [TestFixture]
    public class FixedSizeStackTest
    {

        [Test]
        public void TestStrings()
        {
            dynamic stack = new FixedSizeStack<string>(50);

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
        public void TestInts()
        {
            dynamic stack = new FixedSizeStack<int>(50);

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
