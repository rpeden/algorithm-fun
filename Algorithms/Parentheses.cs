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
        private const char LEFT_PAREN = '(';
        private const char RIGHT_PAREN = ')';

        private const char LEFT_SQUARE = '[';
        private const char RIGHT_SQUARE = ']';

        private const char LEFT_CURLY = '{';
        private const char RIGHT_CURLY = '}';

        public static bool CheckIfBalanced(string parString)
        {
            if (parString.Length == 0) return true;
            var stack = new LinkedStack<char>();

            foreach(char c in parString)
            {
                switch(c)
                {
                    case LEFT_PAREN:
                    case LEFT_SQUARE:
                    case LEFT_CURLY:
                        stack.Push(c);
                        break;
                    case RIGHT_PAREN:
                        if (stack.Size == 0 || stack.Pop() != LEFT_PAREN) return false;
                        break;
                    case RIGHT_SQUARE:
                        if (stack.Size == 0 || stack.Pop() != LEFT_SQUARE) return false;
                        break;
                    case RIGHT_CURLY:
                        if (stack.Size == 0 || stack.Pop() != LEFT_CURLY) return false;
                        break;
                }
            }
            return true;
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
            Assert.AreEqual(false, Parentheses.CheckIfBalanced(testString));
        }
    }
}
