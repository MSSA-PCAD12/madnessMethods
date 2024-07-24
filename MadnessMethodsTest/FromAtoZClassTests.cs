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
    public class FromAtoZClassTests
    {
        [TestMethod()]
        public void testingLowerCase()
        {
            Assert.AreEqual(FromAtoZClass.GimmeTheLetters("a-z"), "abcdefghijklmnopqrstuvwxyz");
        }
 
 
        [TestMethod()]
        public void testingUpperCase()
        {
            Assert.AreEqual(FromAtoZClass.GimmeTheLetters("A-Z"), "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        }
    }
}
