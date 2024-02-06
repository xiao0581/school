using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Student toStringTest = new Student()
            {
                Id = 1,
                Name = "xiao",
                Semester = 1
            };

            String str = toStringTest.ToString();
            Assert.AreEqual("1,xiao,1", str);
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            Student validateNameTest1 = new Student()
            {
                Id = 1,
                Name = "xiao",
                Semester = 2
            };
            validateNameTest1.ValidateName();

            Student validateNameTest2 = new Student()
            {
                Id = 2,
                Name = null,
                Semester = 3
            };

            Assert.ThrowsException<ArgumentNullException>(() => validateNameTest2.ValidateName());

            Student validateNameTest3 = new Student()
            {
                Id = 3,
                Name = "",
                Semester = 4
            };
            Assert.ThrowsException<ArgumentException>(() => validateNameTest3.ValidateName());


        }

        [TestMethod()]
        public void ValidateSemesterTest()
        {
            Student semesterTest = new Student()
            {
                Id = 1,
                Name = "xiao",
                Semester = 5
            };
            semesterTest.ValidateSemester();

            Student semesterTest1 = new Student()
            {
                Id = 1,
                Name = "xiao",
                Semester = 10
            };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => semesterTest1.ValidateSemester());
        }

        [TestMethod()]
        public void GeneralValidatorTest()
        {
            Student generalTest = new Student()
            {
                Id = 1,
                Name = "xiao",
                Semester = 5
            };
            generalTest.GeneralValidator();
           
            Student generalTest1 = new Student()
            {
                Id = 1,
                Name = "",
                Semester = 5
            };
            Assert.ThrowsException<ArgumentException>(() => generalTest1.GeneralValidator());
        }
    }
}



