using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    ///<summary>Creates tests</summary>
    public class Tests
    {
        private List<int> list1 = new List<int>();
        private List<int> list2 = new List<int>();

        [SetUp]
        ///<summary>Sets up lists for tests</summary>
        public void Setup()
        {
            List<int> myList1 = new List<int>() {98, -10, 0, 32, 972, 12, 1024, -727, -98, 50, 8};
            List<int> myList2 = new List<int>() {98, 972, 971, -32, 972, 972, -727};

            list1 = myList1;
            list2 = myList2;
        }

        [Test]
        ///<summary>Tests empty list</summary>
        public void EmptyList()
        {
            Assert.IsTrue(Operations.Max(null) == -1);
        }

        [Test]
        ///<summary>Tests successful list</summary>
        public void SuccessList()
        {
            Assert.IsTrue(Operations.Max(list1) == 1024);
        }

        [Test]
        ///<summary>Tests list with multiple highest</summary>
        public void MultiList()
        {
            Assert.IsTrue(Operations.Max(list2) == 972);
        }
    }
}