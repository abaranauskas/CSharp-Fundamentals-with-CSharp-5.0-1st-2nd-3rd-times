using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculatesHighestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(95f);
            book.AddGrade(75.5f);
            book.AddGrade(85.4f);
            book.AddGrade(100f);

            GradeStatistics stats = book.ComputeStatistics();

           Assert.AreEqual(stats.LowestGrade, 75.5f);

        }

        [TestMethod]
        public void PassByValue()
        {
            GradeBook book = new GradeBook();
            //GradeBook book2 = new GradeBook();

            book.Name = "not set";
            SetName(book);

            //reiktu pasedet prie sito
            Assert.AreEqual("Name i set", book.Name);
            //Assert.ReferenceEquals(book2, book);
            
        }

        private void SetName(GradeBook book)
        {
            book.Name = "Name is set";
        }
    }
}
