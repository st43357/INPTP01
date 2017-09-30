using NUnit.Framework;
using INPTP_AppForFixing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing.Tests
{
    [TestFixture()]
    public class DepartmentTests
    {
        [Test()]
        public void DepartmentCodeShouldBePrettyTest()
        {
            Assert.AreEqual("DPT-HR", new Department() { Name = "HR" }.Code);
            Assert.AreEqual("DPT-HUMAN-RESOURCES", new Department() { Name = "Human Resources" }.Code);
            Assert.AreEqual("DPT-INFORMATION-TECHNOLOGIES-SECURITY", new Department() { Name = "Information Technologies: Security" }.Code);
        }

        [Test()]
        public void DepartmentToStringShouldBeCodeTest()
        {
            const string departmentName = "Human Resources: General Executives";
            Assert.AreEqual(
                new Department() { Name = departmentName }.Code,
                new Department() { Name = departmentName }.ToString());
        }
    }
}