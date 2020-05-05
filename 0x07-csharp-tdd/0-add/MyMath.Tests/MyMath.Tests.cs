using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int a = 2;
            int b = 3;
            int result = Operations.Add(a, b);

            Assert.AreEqual(a + b, result);
        }
    }
}