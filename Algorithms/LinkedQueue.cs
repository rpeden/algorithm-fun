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
                Assert.AreEqual(item, queue.Dequeue);
            }

            Assert.AreEqual(0, queue.Length);
        }
    }
}
