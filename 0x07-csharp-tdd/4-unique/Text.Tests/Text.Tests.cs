using NUnit.Framework;
using System;

namespace Text.Tests
{
    ///<summary>Creates tests</summary>
    public class Tests
    {
        [Test]
        ///<summary>Tests for no unique characters</summary>
        public void NoUnique()
        {
            Assert.IsTrue(Str.UniqueChar("aaaaaaa") == -1);
        }

        [Test]
        ///<summary>Tests for all unique characters</summary>
        public void AllUnique()
        {
            Assert.IsTrue(Str.UniqueChar("abcdefg") == 0);
        }

        [Test]
        ///<summary>Tests for empty string</summary>
        public void Empty()
        {
            Assert.IsTrue(Str.UniqueChar("") == -1);
        }

        [Test]
        ///<summary>Tests for unique at end</summary>
        public void End()
        {
            Assert.IsTrue(Str.UniqueChar("aabbccd") == 6);
        }

        [Test]
        ///<summary>Tests for unique in middle</summary>
        public void Middle()
        {
            Assert.IsTrue(Str.UniqueChar("aabcc") == 2);
        }
    }
}