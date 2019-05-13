using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Data.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int NodeId { get; set; }

        [DisplayName("Meno")]
        public string Name { get; set; }

        [DisplayName("Priezvisko")]
        public string Surname { get; set; }

        [DisplayName("Telefón")]
        public string Phone { get; set; }

        [DisplayName("Emailová adresa")]
        public string Email { get; set; }
    }
}
