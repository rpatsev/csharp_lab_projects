using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubbleSort;

namespace UnitTestBubbleSort
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[] myArray = { 4, 5, 20, 78, 7, 1};
            MyBubbleSort.BubbleSort(myArray);

            Assert.AreEqual(1, myArray[0]);
            Assert.AreEqual(4, myArray[1]);
            Assert.AreEqual(5, myArray[2]);
            Assert.AreEqual(7, myArray[3]);
            Assert.AreEqual(20, myArray[4]);
            Assert.AreEqual(78, myArray[5]);
        }


    }
}
