using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{

    //exactly as the name implies, a fixed size stack of strings
    public class FixedSizeStackOfStrings
    {
        private readonly string[] _stackArray;
        private int _position = 0;

        public int Size
        {
            get
            {
                return _position;
            }
        }

        public FixedSizeStackOfStrings(int size)
        {
            _stackArray = new string[size];
        }

        public void Push(string s)
        {
            _stackArray[_position++] = s;
        }

        public string Pop()
        {
            if (_position == 0) return null;
            return _stackArray[--_position];
        }
    }

    [TestFixture]
    public class FixedSizeStackOfStringsTest
    {
        [Test]
        public void TestPushSingleValue()
        {
            var stack = new FixedSizeStackOfStrings(50);
            var testString = "hello stack";
            stack.Push(testString);
            Assert.AreEqual(1, stack.Size);
            var result = stack.Pop();
            Assert.AreEqual(testString, result);
        }

        [Test]
        public void TestPushMultipleValues()
        {
            var stack = new FixedSizeStackOfStrings(50);
            var testString1 = "Hello Stack";
            var testString2 = "Hello again, stack";
            var testString3 = "We meet again, stack";

            stack.Push(testString1);
            stack.Push(testString2);
            stack.Push(testString3);

            //ensure all strings are in stack
            Assert.AreEqual(3, stack.Size);
            
            Assert.AreEqual(testString3, stack.Pop());
            Assert.AreEqual(testString2, stack.Pop());
            Assert.AreEqual(testString1, stack.Pop());

            //ensure stack is now empty
            Assert.AreEqual(0, stack.Size);
        }

    }
}
