using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            List<int> temp = new List<int> { 1, 2, 3, 4, 5 };

            int result = Operations.Max(temp);

            Assert.AreEqual(5, result);
        }

        [Test]
        public void Test2()
        {
            List<int> temp = new List<int>();

            int result = Operations.Max(temp);

            Assert.AreEqual(0, result);
        }
    }
}