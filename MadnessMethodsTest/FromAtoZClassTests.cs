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
        public void GimmeTheLettersTest()
        {
            Assert.AreEqual(FromAtoZClass.GimmeTheLetters("test"), "The Voodoo, who do What you don't dare do, people");
        }
    }
}