using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    //use a stack to determine if parentheses are correctly balanced
    public class Parentheses
    {
        public static bool CheckIfBalanced(string parString)
        {
            throw new NotImplementedException();
            return false;
        }
    }

    [TestFixture]
    public class ParenthesesTest
    {
        [Test]
        public void TestBalancedParentheses()
        {
            var testString = "[()]{}{[()()]()}";
            Assert.AreEqual(true, Parentheses.CheckIfBalanced(testString));
        }

        [Test]
        public void TestUnbalancedParentheses()
        {
            var testString = "[(])";
            Assert.AreEqual(true, Parentheses.CheckIfBalanced(testString));
        }
    }
}
