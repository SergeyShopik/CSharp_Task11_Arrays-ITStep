using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task11_library;
using System.Collections.Generic;
using System.Linq;

namespace C_sharp_task11_arrays
{
    [TestClass]
    public class Task11Test
    {
        private string[] students = null;
        private int[] marks = null;
        [TestInitialize]
        public void Init()
        {
            students = new string[] { "Butters", "Stan", "Kenny", "Eric", "Kyle"};
            marks = new int[] { 10, 1, 8, 1, 5 };
        }
        //----------------------------------------------------------------------------------------------
        [TestMethod]
        public void GetMinMarkTest_marks_1()
        {
            int expected = 1;
            int actual = Task11.GetMinMark(marks);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetMaxMarkTest_marks_10()
        {
            int expected = 10;
            int actual = Task11.GetMaxMark(marks);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetMinMarkIndexesTest_marks_i1i3()
        {
            List<int> expected = new List<int>() { 1, 3 };
            List<int> actual = Task11.GetMinMarkIndexes(marks);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindMinPerformanceStudentsTest_1_StanEric()
        {
            List<string> expected = new List<string> { "Stan", "Eric" };
            List<string> actual = Task11.FindMinPerformanceStudents(students, marks);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateMeanPerformanceTest_marks_5()
        {
            double expected = 5;
            double actual = Task11.CalculateMeanPerformance(marks);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SortStudentsTest_studentsMarks_sortedAlphabetically()
        {
            string[] expected = new string[] { "Butters", "Eric", "Kenny", "Kyle", "Stan" };
            Task11.SortStudents(ref students, ref marks);
            string[] actual = students;

            for (int i = 0; i < students.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
        //----------------------------------------------------------------------------------------------
        [TestCleanup]
        public void Destroy()
        {
            students = null;
            marks = null;
        }
    }
}
