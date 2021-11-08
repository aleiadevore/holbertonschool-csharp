using NUnit.Framework;
using InventoryManagement;
using InventoryLibrary;
using System;

namespace InventoryManagement.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            JSONStorage storage = new JSONStorage();
            BaseClass obj = new BaseClass();
            storage.mode = "test";
            storage.New(obj);
            string s = $"BaseClass.{obj.id}";
            Assert.IsTrue(storage.objects.ContainsKey(s));

            BaseClass BaseObj = new BaseClass();
            Assert.AreEqual(BaseObj.date_created.Date, DateTime.Now.Date);
            Assert.AreEqual(BaseObj.date_created.GetType(), typeof(DateTime));
        }
    }
}
