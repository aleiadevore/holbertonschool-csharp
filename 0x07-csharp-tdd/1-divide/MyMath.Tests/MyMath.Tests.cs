using NUnit.Framework;

namespace MyMath.Tests
{
    ///<summary>Tests divide function</summary>
    public class Tests
    {
        private int[,] matrix = new int[2,4];

        [SetUp]
        ///<summary></summary>
        public void Setup()
        {
            int[,] _matrix = new int[2,4]{
                {1, 2, 3, 4},
                {2, 3, 4, 5}
            };
            matrix = _matrix;
        }

        [Test]
        ///<summary>Testing successful divide</summary>
        public void SuccessTest()
        {
            Assert.IsTrue(Matrix.Divide(matrix, 1) == matrix);
        }

        [Test]
        ///<summary>Testing divide by 0</summary>
        public void ZeroTest()
        {
            Assert.IsTrue(Matrix.Divide(matrix, 0) == null);
        }

        [Test]
        ///<summary>Testing empty matrix</summary>
        public void EmptyTest()
        {
            Assert.IsTrue(Matrix.Divide(null, 1) == null);
        }
    }
}