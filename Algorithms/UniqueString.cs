using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{

    //check if all characters in a string are unique
    public static class UniqueString
    {
        public static bool IsStringUnique(string stringToCheck)
        {
            if (stringToCheck.Length <= 1) return true;
            var charCounts = new Dictionary<char, int>();

            for (var i = 0; i < stringToCheck.Length; i++)
            {
                if(charCounts.ContainsKey(stringToCheck[i]))
                {
                    return false;
                } else
                {
                    charCounts[stringToCheck[i]] = 1;
                }
            }

            return true;
        }
    }

    [TestFixture]
    public class UniqueStringTest
    {
        [Test]
        public void TestStringIsUnique()
        {
            TestString("abcdefg", true);
        }

        [Test]
        public void TestStringIsNotUnique()
        {
            TestString("aaa", false);
        }

        [Test]
        public void TestSingleCharacterString()
        {
            TestString("a", true);
        }

        [Test]
        public void TestEmptyString()
        {
            TestString("", true);
        }

        private void TestString(string testString, bool expectedResult)
        {
            var result = UniqueString.IsStringUnique(testString);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
