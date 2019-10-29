using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50, ErrorMessage ="The name must not exceed 50 characters")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name="Office Email")]
        public string Email { get; set; }

        [Required]
        public Dept? Department { get; set; }
    }
}
