﻿using NUnit.Framework;
using INPTP_AppForFixing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing.Tests
{
    [TestFixture()]
    public class EmployeeTests
    {
        [Test()]
        public void NewbornEmployeeShouldHaveAgeOf0()
        {
            Employee emp = new Employee()
            {
                OurBirthDate = DateTime.Now
            };

            Assert.AreEqual(0, emp.GetAge());
        }

        [Test()]
        public void OneYearEmployeeShouldHaveAgeOf1()
        {
            DateTime birthDate = DateTime.Now.AddYears(-1).AddSeconds(-5);

            Employee emp = new Employee()
            {
                OurBirthDate = birthDate
            };

            Assert.AreEqual(1, emp.GetAge());
        }

        [Test()]
        public void TenYearEmployeeShouldHaveAgeOf1()
        {
            DateTime birthDate = DateTime.Now.AddYears(-10).AddSeconds(-5);

            Employee emp = new Employee()
            {
                OurBirthDate = birthDate
            };

            Assert.AreEqual(10, emp.GetAge());
        }

        [Test()]
        public void YearlySalaryTestOnIntegerValue()
        {
            Employee emp = new Employee()
            {
                MonthlySalaryCZK = 1000
            };
            double yearlySalary = 1000 * 12;

            Assert.AreEqual(yearlySalary, emp.CalcYearlySalaryCZK());
        }

        [Test()]
        public void YearlySalaryTestOnDoubleValue()
        {
            Employee emp = new Employee();
            { 
                emp.MonthlySalaryCZK = 123.345;
            };
            double yearlySalary = 123.345 * 12;

            Assert.AreEqual(yearlySalary, emp.CalcYearlySalaryCZK());
        }

        [Test()]
        public void CleanYearIncomeShouldBeCorrect()
        {
            Employee emp = new Employee()
            {
                MonthlySalaryCZK = 123.345
            };
            double taxRate = 0.21;
            double cyi = (123.345 * 12) * (1 - taxRate);

            Assert.AreEqual(cyi, emp.CalcYearlyIncome());
        }
    }
}
