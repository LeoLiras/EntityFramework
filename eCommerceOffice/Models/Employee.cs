using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceOffice.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Employee>? Employees { get; set; }
        public ICollection<EmployeeSector>? EmployeesSectors { get; set; }
        public ICollection<Team>? Teams { get; set; }
    }
}
