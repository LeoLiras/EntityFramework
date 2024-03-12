using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceOffice
{
    public class Vehicle
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Identification { get; set; } = null!;
        public ICollection<Vehicle>? Vehicles { get; set; }

    }
}
