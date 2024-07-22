using System;
using System.Collections.Generic;
using System.Linq;
using MadnessMethodsClass;

namespace MadnessMethodsTest
{
    [TestClass]
    public class RemoveSmallestTest
    {
        private static void Tester(List<int> argument, List<int> expectedResult)
        {
            CollectionAssert.AreEqual(expectedResult, RemoveSmallest.RemoveSmallestMethod(argument));
        }

        [TestMethod]
        public void BasicTests()
        {
            Tester(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3, 4, 5 });
            Tester(new List<int> { 5, 3, 2, 6, 4, 1 }, new List<int> { 5, 3, 2, 6, 4 });
            Tester(new List<int> { 1, 2, 3, 1, 1 }, new List<int> { 2, 3, 1, 1 });
            Tester(new List<int>(), new List<int>());
        }

        public void EdgeCases()
        {
            Tester(new List<int> { 1 }, new List<int>());
            Tester(new List<int> { 2, 2, 1, 2, 1 }, new List<int> { 2, 2, 2, 1 });
            Tester(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3, 4, 5 });
            Tester(new List<int> { 5, 4, 3, 2, 1 }, new List<int> { 5, 4, 3, 2 });
            Tester(new List<int> { 0, -1, -2, -3, -4 }, new List<int> { 0, -1, -2, -3 });
            Tester(new List<int> { 1, -1, 2, -2, 3, -3 }, new List<int> { 1, 2, -2, 3, -3 });
        }

        public void DuplicatesTest()
        {
            Tester(new List<int> { 1, 2, 3, 1, 4, 1 }, new List<int> { 2, 3, 1, 4, 1 });
        }

        public void NonSequential()
        {
            Tester(new List<int> { 10, 3, 7, 3, 8, 5 }, new List<int> { 10, 7, 3, 8, 5 });
        }



    }
}
