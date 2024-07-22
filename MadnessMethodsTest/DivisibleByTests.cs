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
            Assert.IsFalse(Three.DivisibleByThree("1891009"));
            Assert.IsTrue(Three.DivisibleByThree("123"));
            Assert.IsTrue(Three.DivisibleByThree("8409"));
            Assert.IsFalse(Three.DivisibleByThree("100853"));
            Assert.IsTrue(Three.DivisibleByThree("33333333"));
            Assert.IsFalse(Three.DivisibleByThree("7"));
        }

        [TestMethod()]
        public void EdgeCaseTests()
        {
            Assert.IsTrue(Three.DivisibleByThree("00009"));
            Assert.IsTrue(Three.DivisibleByThree("57"));
            Assert.IsTrue(Three.DivisibleByThree("0")); // Edge case with single zero
            Assert.IsFalse(Three.DivisibleByThree("1")); // Single digit not divisible by 3
            Assert.IsTrue(Three.DivisibleByThree("3")); // Single digit divisible by 3
            Assert.IsTrue(Three.DivisibleByThree("1234567890")); // Large number
            Assert.IsFalse(Three.DivisibleByThree("1234567891")); // Large number not divisible by 3
            Assert.IsFalse(Three.DivisibleByThree("")); // Empty string should return false
        }

        [TestMethod()]
        public void LargeNumberTests()
        {
            Assert.IsTrue(Three.DivisibleByThree(new string('3', 1000))); // Very large number of '3's
            Assert.IsFalse(Three.DivisibleByThree(new string('1', 1000))); // Very large number of '1's
        }

        [TestMethod()]
        public void RandomTests()
        {
            Assert.IsTrue(Three.DivisibleByThree("258")); // Sum is 15, which is divisible by 3
            Assert.IsFalse(Three.DivisibleByThree("259")); // Sum is 16, which is not divisible by 3
            Assert.IsTrue(Three.DivisibleByThree("369")); // Sum is 18, which is divisible by 3
            Assert.IsFalse(Three.DivisibleByThree("370")); // Sum is 10, which is not divisible by 3
        }

    }
}