﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Sex { get; set; }
        public string? RG {  get; set; }
        public string? CPF { get; set; }
        public string? NomeMae { get; set; }
        public string? RegisterSituation { get; set; }
        public DateTimeOffset RegisterDate { get; set; }
        public Contact? contact { get; set; }
        public ICollection<SendAddress>? SendAddresses { get; set; }
        public ICollection<Department>? Departments { get; set; }
    }
}
