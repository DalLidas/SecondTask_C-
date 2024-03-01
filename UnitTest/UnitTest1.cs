using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingMethods;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShellSortTest1 ()
        {
            // arrange
            List<double> arr = new List<double> ();
            arr.Add(1.2);
            arr.Add(3.1);
            arr.Add(6.7);
            arr.Add(2.9);
            arr.Add(8.2);
            arr.Add(-1.3);

            List<double> sortedArr = new List<double>();
            sortedArr.Add(-1.3);
            sortedArr.Add(1.2);
            sortedArr.Add(2.9);
            sortedArr.Add(3.1);
            sortedArr.Add(6.7);
            sortedArr.Add(8.2);

            // act
            ShellSort shellSort = new ShellSort();
            shellSort.Sort(arr);

            // assert
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] != sortedArr[i])
                {
                    Assert.Fail();
                }
            }

            Assert.AreEqual(11, Convert.ToInt32(shellSort.GetCompareCount()));
            Assert.AreEqual (5, Convert.ToInt32(shellSort.GetSwapCount()));
        }

        [TestMethod]
        public void ShellSortTest2()
        {
            // arrange
            List<double> arr = new List<double>();
            arr.Add(22);
            arr.Add(0);
            arr.Add(6.7);
            arr.Add(5.3334);
            arr.Add(23);
            arr.Add(-3);

            List<double> sortedArr = new List<double>();
            sortedArr.Add(-3);
            sortedArr.Add(0);
            sortedArr.Add(5.3334);
            sortedArr.Add(6.7);
            sortedArr.Add(22);
            sortedArr.Add(23);

            // act
            ShellSort shellSort = new ShellSort();
            shellSort.Sort(arr);

            // assert
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] != sortedArr[i])
                {
                    Assert.Fail();
                }
            }

            Assert.AreEqual(11, Convert.ToInt32(shellSort.GetCompareCount()));
            Assert.AreEqual(7, Convert.ToInt32(shellSort.GetSwapCount()));
        }

        [TestMethod]
        public void ShellSortTest3()
        {
            // arrange
            List<double> arr = new List<double>();
            arr.Add(Double.MaxValue);
            arr.Add(Double.MinValue);

            List<double> sortedArr = new List<double>();
            sortedArr.Add(Double.MinValue);
            sortedArr.Add(Double.MaxValue);

            // act
            ShellSort shellSort = new ShellSort();
            shellSort.Sort(arr);

            // assert
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] != sortedArr[i])
                {
                    Assert.Fail();
                }
            }

            Assert.AreEqual(1, Convert.ToInt32(shellSort.GetCompareCount()));
            Assert.AreEqual(1, Convert.ToInt32(shellSort.GetSwapCount()));
        }

        [TestMethod]
        public void ShekerSortTest4()
        {
            // arrange
            // arrange
            List<double> arr = new List<double>();
            arr.Add(1.2);
            arr.Add(3.1);
            arr.Add(2.9);
            arr.Add(8.2);
            arr.Add(-1.3);

            List<double> sortedArr = new List<double>();
            sortedArr.Add(-1.3);
            sortedArr.Add(1.2);
            sortedArr.Add(2.9);
            sortedArr.Add(3.1);
            sortedArr.Add(8.2);

            // act
            ShekerSort shekerSort = new ShekerSort();
            shekerSort.Sort(arr);

            // assert
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] != sortedArr[i])
                {
                    Assert.Fail();
                }
            }

            Assert.AreEqual(10, Convert.ToInt32(shekerSort.GetCompareCount()));
            Assert.AreEqual(5, Convert.ToInt32(shekerSort.GetSwapCount()));
        }

        [TestMethod]
        public void ShekerSortTest5()
        {
            // arrange
            List<double> arr = new List<double>();
            arr.Add(22);
            arr.Add(0);
            arr.Add(6.7);
            arr.Add(5.3334);
            arr.Add(-3);

            List<double> sortedArr = new List<double>();
            sortedArr.Add(-3);
            sortedArr.Add(0);
            sortedArr.Add(5.3334);
            sortedArr.Add(6.7);
            sortedArr.Add(22);

            // act
            ShekerSort shekerSort = new ShekerSort();
            shekerSort.Sort(arr);

            // assert
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] != sortedArr[i])
                {
                    Assert.Fail();
                }
            }

            Assert.AreEqual(10, Convert.ToInt32(shekerSort.GetCompareCount()));
            Assert.AreEqual(8, Convert.ToInt32(shekerSort.GetSwapCount()));
        }
    }
}