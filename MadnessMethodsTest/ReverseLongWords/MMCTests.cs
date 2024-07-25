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
    public class MMCTests
    {
        [TestMethod()]
        public void MMCombineStringTest()
        {
            // Arrange
            IEnumerable<string> enumString = new List<string> { "this", "is", "a", "test" }; // normal 
            IEnumerable<string> enumString2 = new List<string> { "this", "is", "a", "detacilpmoc", "test" }; // with one reversed string
            IEnumerable<string> enumString3 = new List<string>(); // empty IEnumerable<string>

            // Act
            string output1 = MMC.MMCombineString(enumString);
            string output2 = MMC.MMCombineString(enumString2);
            string output3 = MMC.MMCombineString(enumString3);

            //Asset
            Assert.AreEqual(output1, "this is a test");
            Assert.AreEqual(output2, "this is a detacilpmoc test");
            Assert.AreEqual(output3, "");
        }

    }
}