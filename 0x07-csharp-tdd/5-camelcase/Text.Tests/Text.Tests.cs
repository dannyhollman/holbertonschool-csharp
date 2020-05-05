using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string temp = "howManyWords";

            int result = Str.CamelCase(temp);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test2()
        {
            string temp = "test";

            int result = Str.CamelCase(temp);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test3()
        {
            string temp = "";

            int result = Str.CamelCase(temp);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test4()
        {
            string temp = null;

            int result = Str.CamelCase(temp);

            Assert.AreEqual(0, result);
        }
    }
}