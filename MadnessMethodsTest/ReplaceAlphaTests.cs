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
            // Act
            var result = ReplaceAlpha.AlphabetPosition("The sunset sets at twelve o' clock.");

            // Assert
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", result);

        }

        //[TestMethod]
        //public void EmptyString()
        //{
        //    // Act
        //    var result = Unique.UniqueInOrder("");

        //    // Assert
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(0, result.Count());
        //}
    }
}