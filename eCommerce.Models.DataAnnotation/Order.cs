using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Order
    {
        public int Id { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("Supervisor")]
        public int SupervisorId { get; set; }

        public User? Client {  get; set; }
        public User? Employee { get; set; }
        public User? Supervisor { get; set; }

    }
}
