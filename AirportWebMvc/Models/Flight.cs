using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebMvc.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destiny { get; set; }
        public DateTime Boarding { get; set; }
        public double Price { get; set; }
    }
}
