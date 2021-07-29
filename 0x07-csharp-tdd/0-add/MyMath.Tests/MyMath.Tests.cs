using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    ///<summary>Tests add function</summary>
    public class Tests
    {
        [Test]
        public void TestSuccess()
        {
            var result = Operations.Add(1, 1);
            Assert.IsTrue(result == 2, "1 + 1 = 2");
        }
    }
}