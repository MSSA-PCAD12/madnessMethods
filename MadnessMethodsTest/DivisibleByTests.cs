using Microsoft.VisualStudio.TestTools.UnitTesting;
using MadnessMethodsClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass.Tests
{
    [TestClass]
    public class DivisibleByTests
    {
        [TestMethod()]
        public void BasicTests()
        {
            Assert.IsTrue(Three.DivisibleByThree("123"));
            Assert.IsTrue(Three.DivisibleByThree("8409"));
            Assert.IsFalse(Three.DivisibleByThree("100853"));
            Assert.IsTrue(Three.DivisibleByThree("33333333"));
            Assert.IsFalse(Three.DivisibleByThree("7"));
        }

        [TestMethod()]
        public void EdgeCaseTests()
        {
            Assert.IsTrue(Three.DivisibleByThree("00009")); // Sum is 9, divisible by 3
            Assert.IsTrue(Three.DivisibleByThree("57")); // Sum is 12, divisible by 3
            Assert.IsTrue(Three.DivisibleByThree("0")); // Sum is 0, divisible by 3
            Assert.IsFalse(Three.DivisibleByThree("1")); // Sum is 1, not divisible by 3
            Assert.IsTrue(Three.DivisibleByThree("3")); // Sum is 3, divisible by 3
            Assert.IsTrue(Three.DivisibleByThree("1234567890")); // Sum is 45, divisible by 3
            Assert.IsFalse(Three.DivisibleByThree("1234567891")); // Sum is 46, not divisible by 3
            Assert.IsFalse(Three.DivisibleByThree("")); // Empty string should return false
        }

        [TestMethod()]
        public void LargeNumberTests()
        {
            Assert.IsTrue(Three.DivisibleByThree(new string('3', 1000))); // Sum is 3000, divisible by 3
            Assert.IsFalse(Three.DivisibleByThree(new string('1', 1000))); // Sum is 1000, not divisible by 3
        }

        [TestMethod()]
        public void RandomTests()
        {
            Assert.IsTrue(Three.DivisibleByThree("258")); // Sum is 15, divisible by 3
            Assert.IsFalse(Three.DivisibleByThree("259")); // Sum is 16, not divisible by 3
            Assert.IsTrue(Three.DivisibleByThree("369")); // Sum is 18, divisible by 3
            Assert.IsFalse(Three.DivisibleByThree("370")); // Sum is 10, not divisible by 3
        }

    }
}