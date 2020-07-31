using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOrganizer.Domain.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Power { get; set; }
        public Client Client { get; set; }
    }
}
