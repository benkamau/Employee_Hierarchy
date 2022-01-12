using System;
using EmployeeLibrary;
namespace RunEmployeeLibrary
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Employees employees = new Employees(
                "name1,manager1,5600, " + 
                
                "name2,manager2,2000, " +

                "name3,manager3,8900, " + 

                "name4,'',10000, " +    // ceo

                "manager1,name4,9000 ," +   // manager1 under ceo

                "manager2,name4,9000, " +

                "manager3,name4,9000, "  
                );

            int salary = employees.managerSalaryBudget("manager1");

            Console.WriteLine(salary);
        }
    }
}
