using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }


        [Required]
        [MaxLength(50,ErrorMessage ="Name cannot exceed 50 characters")]
        public string Name { get; set; }


        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$",ErrorMessage ="Invalid Email format")]
        [Display(Name="Office Email")]
        [Required]
        public string Email { get; set; }

        [Required]
        public Dept? Department { get; set; }
    }
}
