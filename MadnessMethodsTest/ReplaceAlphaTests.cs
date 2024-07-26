using Microsoft.VisualStudio.TestTools.UnitTesting;
using MadnessMethodsClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass.Tests
{
    [TestClass()]
    public class ReplaceAlphaTests
    {
        [TestMethod()]
        public void BasicTests()
        {
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", ReplaceAlpha.AlphabetPosition("The sunset sets at twelve o' clock."));
            Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", ReplaceAlpha.AlphabetPosition("The narwhal bacons at midnight."));
        }

        [TestMethod]
        public void EmptyString()
        {
            // Act
            var result = ReplaceAlpha.AlphabetPosition("");

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void NonAlphabetCharactersTest()
        {
            // Act
            var result = ReplaceAlpha.AlphabetPosition("12345!@#$%");

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void RepeatingCharactersTest()
        {
            // Act
            var result = ReplaceAlpha.AlphabetPosition("aaaaa");

            // Assert
            Assert.AreEqual("1 1 1 1 1", result);
        }

        [TestMethod]
        public void LongStringTest()
        {
            // Act
            string longInput = new string('a', 1000);
            string expectedOutput = string.Join(" ", Enumerable.Repeat("1", 1000));

            // Assert
            Assert.AreEqual(expectedOutput, ReplaceAlpha.AlphabetPosition(longInput));
        }

        [TestMethod()]
        public void StringWithNumbersAndPunctuationTest()
        {
            var result = ReplaceAlpha.AlphabetPosition("The sun sets at 10:30!");
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 1 20", result);
        }

        [TestMethod()]
        public void StringWithNumbersAndPunctuationTest2()
        {
            var result = ReplaceAlpha.AlphabetPosition2("The sun sets at 10:30!");
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 1 20", result);
        }
    }
}