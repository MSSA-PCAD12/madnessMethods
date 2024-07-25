using Microsoft.VisualStudio.TestTools.UnitTesting;
using MadnessMethodsClass.ReverseLongWords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadnessMethodsClass.ReverseLongWords.Tests
{
    [TestClass()]
    public class MMBTests
    {
        [TestMethod()]
        public void MMReverseLongWordsTest()
        {
            // Arrange
            IEnumerable<string> input = new List<string> { "hello", "world", "CSharp" };
            IEnumerable<string> expected = new List<string> { "olleh", "dlrow", "prahSC" };

            // Act
            IEnumerable<string> actual = input.MMReverseLongWords();

            // Assert
            CollectionAssert.AreEqual(expected.ToList(), actual.ToList());
        }
    }
}