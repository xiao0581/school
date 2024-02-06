using Microsoft.VisualStudio.TestTools.UnitTesting;
using school;
using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Tests
{
    [TestClass()]
    public class teacherTests
    {
        [TestMethod()]
        public void ValidateNameTest()
        {
            teacher teacher = new teacher()
            {
                Id = 1,
                Name = "xiao",
                Salary = 100.0
            };
            teacher.ValidateName();

            teacher teacher1 = new teacher()
            {
                Id = 2,
                Name = null,
                Salary = 100.0
            };
            Assert.ThrowsException<ArgumentNullException>(() => teacher1.ValidateName());


            teacher teacher2 = new teacher()
            {
                Id = 2,
                Name = "",
                Salary = 100.0
            };
            Assert.ThrowsException<ArgumentException>(() => teacher2.ValidateName());

        }
        [TestMethod()]
        public void ValidateSalaryTest()
        {
            //  ?
            teacher salaryLowTest = new teacher()
            {
                Id = 5,
                Name = "xiao",
                Salary = 2
            };
            salaryLowTest.ValidateSalary();

            teacher salaryTest = new teacher()
            {
                Id = 5,
                Name = "xiao",
                Salary = 0
            };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => salaryTest.ValidateSalary());


        }

        [TestMethod()]
        public void GeneralValidatorTest()
        {
            teacher genneralSalaryValidatior = new teacher()
            {
                Id = 6,
                Name = "xiao",
                Salary = 0
            };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => genneralSalaryValidatior.GeneralValidator());

            teacher genneralNameValidatior = new teacher()
            {
                Id = 6,
                Name = "",
                Salary = 2
            };
            Assert.ThrowsException<ArgumentException>(() => genneralNameValidatior.GeneralValidator());
        }


        [TestMethod()]
        public void ToStringTest()
        {
            teacher ToStringTest = new teacher()
            {
                Id = 5,
                Name = "xiao",
                Salary = 1
            };
            String str = ToStringTest.ToString();
            Assert.AreEqual("5,xiao,1", str);
        }
        [TestMethod()]
        public void ClassIsNotNullTest()
        {
            //arrange
            teacher classTest = new teacher();

            //act no need

            //Assert

            Assert.IsNotNull(classTest.Class);

        }
        [TestMethod()]
        public void GenderTest()
        {
            //Arrange
            Person p1 = new Person();

            //act
            p1.Gender = GenderType.Male;

            //assert

            Assert.AreEqual(GenderType.Male, p1.Gender);


        }

        [TestMethod()]
        public void EqualsTest()
        {
            //arrange
            teacher t1 = new teacher() { Id = 1 };
            teacher t2 = new teacher() { Id = 1 };
            //act&assert
            Assert.IsTrue(t1.Equals(t2));


        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            //arrange
            teacher t1 = new teacher() { Id = 1, Name = "xiao" };
            teacher t2 = new teacher() { Id = 2, Name = "na" };
            //act&assert
            Assert.AreNotEqual(t1.GetHashCode, t2.GetHashCode);
        }
        [TestMethod()]
        public void TestITeacher()
        {
            teacher t1 = new teacher();

            Assert.IsTrue(t1 is Iteacher);
        }
    }
}