using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceOffice.Models
{
    public class EmployeeSector
    {

        public int EmployeeId { get; set; }
        public int SectorId { get; set; }
        public Employee? Employee { get; set; }
        public Sector? Sector { get; set; }
    }
}
