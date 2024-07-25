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
    public class KataSolutionTests
    {
        [TestMethod]
        public void SpinWordsTest1()
        {
            Assert.AreEqual("emocleW", KataSolution.SpinWords("Welcome"));
        }

        [TestMethod]
        public void SpinWordsTest2()
        {
            Assert.AreEqual("Hey wollef sroirraw", KataSolution.SpinWords("Hey fellow warriors"));
        }

        [TestMethod]
        public void SpinWordsTest3()
        {
            Assert.AreEqual("This is a test", KataSolution.SpinWords("This is a test"));
        }

        [TestMethod]
        public void SpinWordsTest4()
        {
            Assert.AreEqual("This is rehtona test", KataSolution.SpinWords("This is another test"));
        }

        [TestMethod]
        public void SpinWordsTest5()
        {
            Assert.AreEqual("You are tsomla to the last test", KataSolution.SpinWords("You are almost to the last test"));
        }

        [TestMethod]
        public void SpinWordsTest6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", KataSolution.SpinWords("Just kidding there is still one more"));
        }
    }
}