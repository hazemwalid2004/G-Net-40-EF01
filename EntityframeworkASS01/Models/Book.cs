using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkASS01.Models
{
    internal class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int noOfPages { get; set; }
        public DateTime year { get; set; }
    }
}
