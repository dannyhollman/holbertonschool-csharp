using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[,] temp = new int[2,2] { { 2, 4 }, { 6, 8 } };
            int num = 2;

            int[,] result = Matrix.Divide(temp, num);

            Assert.AreEqual(new int[2,2] { { 1, 2 }, { 3, 4 } }, result);
        }

        [Test]
        public void Test2()
        {
            int[,] temp = new int[2,2] { { 2, 4 }, { 6, 8 } };
            int num = 0;

            int[,] result = Matrix.Divide(temp, num);

            Assert.AreEqual(null, result);
        }

        [Test]
        public void test3()
        {
            int[,] temp = null;
            int num = 2;

            int[,] result = Matrix.Divide(temp, num);

            Assert.AreEqual(null, result);
        }
    }
}