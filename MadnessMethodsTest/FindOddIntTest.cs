using MadnessMethodsClass;

namespace FindOddIntTest
{
    [TestClass]
    public class FindOddIntTest
    {
        [TestMethod]
        [DataRow(new int[] { 7 }, 7)] // "normal input" situations
        [DataRow(new int[] { 0 }, 0)]
        [DataRow(new int[] { 1, 1, 2 }, 2)]
        [DataRow(new int[] { 0, 1, 0, 1, 0 }, 0)]
        [DataRow(new int[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 }, 4)]
        [DataRow(new int[] { -1, -1, -2 }, -2)] // negative numbers
        public void TestMethod1(int[] seq, int expected)
        {
            // "normal input" situations where the method returns the
            // one integer that appears an odd number of items

            // Arange handled by DataRow accessories

            // Act
            int result = FindOddInt.FindInt(seq);

            // Assert (expected is declared in the DataRow Accessories)
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void HandlesEmptyArray()
        {
            // empty array should return -1

            // arrange
            int[] intArray = Array.Empty<int>();

            // act
            int result = FindOddInt.FindInt(intArray);

            // assert should return -1
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void ReturnNegativeOneIfNoAnswer()
        {
            // an array that does not contain an integer that appears an
            // odd number of times should return -1

            // arrange
            int[] intArray = { 2, 2 };

            // act
            int result = FindOddInt.FindInt(intArray);

            // assert should return -1
            Assert.AreEqual(-1, result);
        }

    }
}
