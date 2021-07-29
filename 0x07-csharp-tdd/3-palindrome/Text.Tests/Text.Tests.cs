using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        ///<summary>Returns true for even-numbered palindrome</summary>
        public void EvenTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("No lemon no melon"));
        }

        [Test]
        ///<summary>Returns true for odd-numbered palindrome</summary>
        public void OddTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("racecar"));
        }

        [Test]
        ///<summary>Returns true for empty string</summary>
        public void Empty()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [Test]
        ///<summary>Returns False for non palindrome</summary>
        public void NonPalindrome()
        {
            Assert.IsFalse(Str.IsPalindrome("Holberton"));
        }
    }
}