using Microsoft.VisualStudio.TestTools.UnitTesting;
using CLX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLX.Tests
{
    [TestClass()]
    public class MaxHeapTests
    {
        [TestMethod()]
        public void MaxHeapTest()
        {
            List<int> testList = new List<int> {9,8,7,6,5,1,888,8};
            testList.Sort((x, y) => y - x);
            MaxHeap<int> maxHeap = new MaxHeap<int>(testList);
            foreach (var v in testList)
            {
                Assert.AreEqual(v, maxHeap.RemoveDominating());
            }
        }

        [TestMethod()]
        public void MaxHeapTest1()
        {
            List<int> testList = new List<int> { 465, 1, 8, 9, 10 };
            testList.Sort((x, y) => y - x);
            MaxHeap<int> maxHeap = new MaxHeap<int> (testList);
            foreach(var v in testList)
            {
                Assert.AreEqual(v, maxHeap.RemoveDominating());
            }
        }
    }
}