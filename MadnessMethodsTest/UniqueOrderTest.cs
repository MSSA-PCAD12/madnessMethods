using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace MadnessMethodsClass.Tests
{
    [TestClass]
    public class UniqueOrderTest
    {
        [TestMethod]
        public void UniqueInOrderTest_EmptyString()
        {
            // Act
            var result = Unique.UniqueInOrder("");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void UniqueInOrderTest_NullInput()
        {
            // Act
            var result = Unique.UniqueInOrder<string>(null);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 2, 3, 3 }, new int[] { 1, 2, 3 })]
        [DataRow(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1 })]
        public void UniqueInOrderTest_IntArray(int[] input, int[] expected)
        {
            // Act
            var result = Unique.UniqueInOrder(input);

            // Assert
            CollectionAssert.AreEqual(expected.ToList(), result.ToList());
        }

        [DataTestMethod]
        [DataRow(new char[] { 'A', 'A', 'B', 'B', 'C', 'C', 'D', 'A', 'A', 'B', 'B', 'B' }, new char[] { 'A', 'B', 'C', 'D', 'A', 'B' })]
        public void UniqueInOrderTest_CharArray(char[] input, char[] expected)
        {
            // Act
            var result = Unique.UniqueInOrder(input);

            // Assert
            CollectionAssert.AreEqual(expected.ToList(), result.ToList());
        }
    }
}
