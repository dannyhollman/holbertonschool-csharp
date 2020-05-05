using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string temp = "Racecar";

            bool result = Str.IsPalindrome(temp);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void Test2()
        {
            string temp = "levell";

            bool result = Str.IsPalindrome(temp);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Test3()
        {
            string temp = "A man, a plan, a canal: Panama.";

            bool result = Str.IsPalindrome(temp);

            Assert.AreEqual(true, result);
        }
    }
}