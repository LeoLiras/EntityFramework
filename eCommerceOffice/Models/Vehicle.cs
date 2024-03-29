﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceOffice.Models
{
    public class Vehicle
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Identification { get; set; } = null!;
        public ICollection<Employee>? Employees { get; set; }
        public ICollection<EmployeeVehicle>? EmployeesVehicles { get; set; }
    }
}
