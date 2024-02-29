using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class SendAddress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string AddressName { get; set; } = null!;
        public string CEP { get; set; } = null!;
        public string State { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Neighborhood { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Number { get; set; }
        public string? Complement { get; set; }
        public User? User { get; set; }

    }
}
