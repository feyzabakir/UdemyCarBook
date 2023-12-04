using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class Service
    {
        public int ServiceID { get; set; }
        public int Title { get; set; }
        public int Description { get; set; }
        public int IconUrl { get; set; }
    }
}
