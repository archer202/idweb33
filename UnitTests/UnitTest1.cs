﻿using NUnit.Framework;

namespace UnitTests
{
    public class Tests
    {
        [Test]
        public void Test1Andriuha()
        {
            var stringOne = "Fedea";
            var stringTwo = "Andriuha";

            if (stringOne == stringTwo)
                Assert.Fail();
            else
                Assert.Pass();
        }

        [Test]
        public void Test2Andriuha()
        {
            var stringOne = "Fedea";
            var stringTwo = "Fedea";

            if (stringOne == stringTwo)
                Assert.Fail();
            else
                Assert.Pass();
        }

        [Test]
        public void Test3Andriuha()
        {
            var arrayOne = new int[] { 1, 2, 4, 6, 7 };

            for (int i = 0; i < arrayOne.Length; i++)
                if (arrayOne[i] == 1)
                    Assert.Pass();
            Assert.Fail();
        }
    }
}