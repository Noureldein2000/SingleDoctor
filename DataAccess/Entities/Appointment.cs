using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Appointment : BaseEntity<int>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Note { get; set; }
        public DateTime AppointDate { get; set; }
    }
}
