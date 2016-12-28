using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.SalaryCalculationWinApp {
   public class Salary {
        public decimal BasicSalary { get; set; }
        public decimal MedicalPercentage { get; set; }
        public decimal ConveyancePercentage { get; set; }
        public int NoOfIncrement { get; set; }

        public decimal MedicalOfBasic { get; set; }
        public decimal ConveyanceOfBasic { get; set; }

        public decimal TotalSalary { get; set; }


       public decimal IncrementSalary(decimal incrementAmount)
       {
           decimal basicSalary = BasicSalary*incrementAmount/100;
           BasicSalary += basicSalary;
           basicSalary = BasicSalary;
           NoOfIncrement += 1;
           Medical();
           Conveyance();
           Total();
           return basicSalary;
       }

       public void Medical()
       {
           decimal medical = BasicSalary*MedicalPercentage/100;
           MedicalOfBasic = medical;
       }
       public void Conveyance() {
           decimal conveyance = BasicSalary * ConveyancePercentage / 100;
           ConveyanceOfBasic = conveyance;
       }
       public void Total() {
           decimal total = BasicSalary +MedicalOfBasic+ConveyanceOfBasic;
           TotalSalary = total;
       }
    }
}
