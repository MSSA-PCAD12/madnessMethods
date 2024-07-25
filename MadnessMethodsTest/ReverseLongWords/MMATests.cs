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
    public class MMATests
    {
        [TestMethod()]
        public void MMSplitStringTest()
        {
            string input = "abc def ghijklmn 1234";
            IEnumerable<string> expected = input.Split(' ');
            Assert.IsTrue(expected.SequenceEqual(input.MMSplitString()));

        }

        [TestMethod()]
        public void MMSplitEmptyTest()
        {
            string input = "";
            IEnumerable<string> expected = input.Split(' ');
            Assert.AreEqual(0, input.MMSplitString().Count());
        }
    }
}