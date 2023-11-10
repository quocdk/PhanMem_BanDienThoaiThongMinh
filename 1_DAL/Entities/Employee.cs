using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public bool Sex { get; set; }
        public string LinkImage { get; set; }
        public bool Status { get; set; }
        public string Role { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public virtual List<Bill> Bills { get; set; }
    }
}
