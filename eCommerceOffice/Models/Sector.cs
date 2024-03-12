﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceOffice.Models
{
    public class Sector
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<EmployeeSector>? EmployeesSectors { get; set; }
    }
}
