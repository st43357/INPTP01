using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    public class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private string job; 
        private DateTime ourBirthDate;
        private double monthlySalaryCZK;      
        private static double taxRate = 0.21;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Job { get => job; set => job = value; }
        public DateTime OurBirthDate { get => ourBirthDate; set => ourBirthDate = value; }
        public double MonthlySalaryCZK { get => monthlySalaryCZK; set => monthlySalaryCZK = value; }
        public static double TaxRate { get => taxRate; }

        /// <summary>
        /// This method gets age of employee
        /// </summary>
        /// <returns>Age of employee</returns>

        public int GetAge()
        {
            DateTime endDate = DateTime.Now;
            TimeSpan timeSpan = endDate - OurBirthDate;
            if (timeSpan.TotalDays > 365)
            {
                return (int)Math.Round((timeSpan.TotalDays / 365), MidpointRounding.ToEven);
            }
            else
            {
                return 0;
            }
                
        }

        public virtual double CalcYearlySalaryCZK()
        {
            return MonthlySalaryCZK * 12;
        }
               
        public virtual double CalcYearlyIncome()
        {
            return CalcYearlySalaryCZK() * (1 - TaxRate);
        }
    }
}
