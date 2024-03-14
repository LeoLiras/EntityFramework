using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceOffice.Models
{
    public class EmployeeVehicle
    {
        public int EmployeeId { get; set; }
        public int VehicleId { get; set; }
        public DateTimeOffset InitialBondDate { get; set; }

        public Employee? Employee { get; set; }
        public Vehicle? Vehicle { get; set; }
    }
}
