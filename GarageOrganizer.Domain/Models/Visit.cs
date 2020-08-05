using System;
using System.Collections.Generic;
using System.Text;

namespace GarageOrganizer.Domain.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public DateTime CreatedAt { get; set; }
        public string[] Repairs { get; set; } 
    }
}
