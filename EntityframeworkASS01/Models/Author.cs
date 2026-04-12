using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkASS01.Models
{
    internal class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string shortbiography {  get; set; }
        public DateTime dateOfBirth { get; set; }
    }
}
