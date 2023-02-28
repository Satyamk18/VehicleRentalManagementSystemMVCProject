using System;
using System.Collections.Generic;

#nullable disable

namespace VehicleRentalManagementProject.Models
{
    public partial class StudentCollege
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public int? Rollno { get; set; }
        public string Address { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public int? Batch { get; set; }
        public decimal? Cgpa { get; set; }
    }
}
