using Microsoft.VisualStudio.TestTools.UnitTesting;
using MadnessMethodsClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MadnessMethodsClass;

namespace MadnessMethodsClass.Tests
{
    [TestClass()]
    public class Testing123Tests
    {
        [TestMethod()]
        public void Testing123MethodTest()
        {
            //List<string> input = new List<string> { "a", "b", "c" };
            //List<string> output = new List<string> { "1: a", "2: b", "3: c" };

            //List<string> result = Testing123.Testing123Method(input);

            CollectionAssert.AreEqual(new List<string> { "1: a", "2: b", "3: c" }, Testing123.Testing123Method(new List<string> { "a", "b", "c" }));

        }

        [TestMethod()]
        public void Testing123MethodTest2()
        {

            CollectionAssert.AreEqual(new List<string> { "1: c", "2: d", "3: e" }, Testing123.Testing123Method(new List<string> { "c", "d", "e" }));

        }
        [TestMethod()]
        public void Testing123MethodTest3()
        {

            CollectionAssert.AreEqual(new List<string> { "1: a", "2: b", "3: c", "4: dinosaur", "5: elephant", "6: aligator", "7: cheetah", "8: kangaroo" }, Testing123.Testing123Method(new List<string> { "a", "b", "c", "dinosaur","elephant","aligator","cheetah", "kangaroo"  }));

        }

        [TestMethod()]
        public void Testing123MethodEmptyString()
        {

            CollectionAssert.AreEqual(new List<string> {}, Testing123.Testing123Method(new List<string> { }));

        }
    }
}