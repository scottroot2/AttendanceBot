using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttendanceBot.Data;
namespace AttendanceBot.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AttendanceRepo repo = new AttendanceRepo();
            //repo.SaveData(
            //    new Models.Student { StudentId = 123456, FirstName = "Scott", LastName = "Root" }
            //    );

            Assert.IsTrue(repo.GetStudents().Count > 0);
        }
    }
}
