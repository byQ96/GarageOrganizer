using GarageOrganizer.Domain.Enums;
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
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public FuelType FuelType { get; set; }
        public int EngineCapacity { get; set; }
        public int Power { get; set; }
        public int VIN { get; set; }
        public Client Client { get; set; }
        public ICollection<Visit> Visits { get;set; }
    }
}
