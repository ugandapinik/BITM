using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT.SalaryCalculationWinApp {
   public class Employee {
       public string Id { get; set; }
       public string Name { get; set; }
       public string Email { get; set; }
       public Salary EmployeeSalary { get; set; }
    }
}
