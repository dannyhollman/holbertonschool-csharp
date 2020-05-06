using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string temp = "abbbbb";

            int result = Str.UniqueChar(temp);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test2()
        {
            string temp = "bbbbba";

            int result = Str.UniqueChar(temp);

            Assert.AreEqual(5, result);
        }

        [Test]
        public void Test3()
        {
            string temp = "bbbbbb";

            int result = Str.UniqueChar(temp);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Test4()
        {
            string temp = "";

            int result = Str.UniqueChar(temp);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Test5()
        {
            string temp = null;

            int result = Str.UniqueChar(temp);

            Assert.AreEqual(-1, result);
        }
    }
}