using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaryCalculationWebApp {
    [Serializable]
    public class Salary
    {
        public decimal basicSalary;
        public decimal conveyancePercentage;
        public decimal houseRentPercentage;

        public decimal CalculateTotalSalary()
        {
            decimal conveyanceAmount = basicSalary * conveyancePercentage / 100;
            decimal houseRentAmount = basicSalary * houseRentPercentage / 100;
            decimal totalSalary = basicSalary + conveyanceAmount + houseRentAmount;
            return totalSalary;
        }
    }
}