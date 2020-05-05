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
    }
}