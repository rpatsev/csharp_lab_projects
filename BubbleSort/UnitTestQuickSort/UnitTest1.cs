using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace UnitTestQuickSort
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] myArray = { 3, 7, 8, 5, 2, 1, 9, 4, 6 };

            MyQuickSort.QuickSort(myArray, 0, myArray.Length-1);

            Assert.AreEqual(1, myArray[0]);
            Assert.AreEqual(2, myArray[1]);
            Assert.AreEqual(3, myArray[2]);
            Assert.AreEqual(4, myArray[3]);
            Assert.AreEqual(5, myArray[4]);
            Assert.AreEqual(6, myArray[5]);
            Assert.AreEqual(7, myArray[6]);
            Assert.AreEqual(8, myArray[7]);
            Assert.AreEqual(9, myArray[8]);
        }
    }
}
