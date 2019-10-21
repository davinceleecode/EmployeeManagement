using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Mary", Department = "HR", Email = "mary@davinceleecode.com"},
                new Employee() {Id = 2, Name = "Rose", Department = "IT", Email = "rose@davinceleecode.com"},
                new Employee() {Id = 3, Name = "Lee", Department = "IT", Email = "lee@davinceleecode.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }
    }
}
 