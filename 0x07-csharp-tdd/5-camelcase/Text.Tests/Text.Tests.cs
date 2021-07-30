using NUnit.Framework;
using System;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        ///<summary>Tests empty string</summary>
        public void Empty()
        {
            Console.WriteLine(Str.CamelCase(""));
            Assert.IsTrue(Str.CamelCase("") == 0);
        }

        [Test]
        ///<summary>Testing one word</summary>
        public void Test1()
        {
            Console.WriteLine(Str.CamelCase("one"));
            Assert.IsTrue(Str.CamelCase("one") == 1);
        }

        [Test]
        ///<summary>Testing five words</summary>
        public void Test5()
        {
            Console.WriteLine(Str.CamelCase("thisIsALongWord"));
            Assert.IsTrue(Str.CamelCase("thisIsALongWord") == 5);
        }
    }
}