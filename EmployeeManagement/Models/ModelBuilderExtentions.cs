using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
              new Employee
              {
                  Id = 1,
                  Name = "vincent",
                  Department = Dept.IT,
                  Email = "vincent@davinceleecode.com"
              },
               new Employee
               {
                   Id = 2,
                   Name = "via",
                   Department = Dept.HR,
                   Email = "via@davinceleecode.com"
               },
                new Employee
                {
                    Id = 3,
                    Name = "rose",
                    Department = Dept.Payroll,
                    Email = "rose@davinceleecode.com"
                }
              );
        }
    }
}
